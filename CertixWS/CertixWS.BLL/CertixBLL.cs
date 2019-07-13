using CertixWS.Data;
using CertixWS.Entities;
using CertixWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertixWS.BLL
{
    public class CertixBLL
    {
        public int CreateIdMeasureFromCodeAndIdLine(int IdLine, string Code, bool IsTest, out List<string> Measures)
        {
            Measures = new List<string>();
            if (IsTest)
            {
                if (IdLine < 0)
                {
                    string m = string.Format("Codice IdLine: {0} non valido", IdLine);
                    throw new ArgumentException(m);
                }

                if (Code == "12345678912345") Measures = new List<string>(new string[] { "Au", "Ni", "Pd" });

                if (Code == "12345678912345") return DateTime.Now.Minute;

                string messaggio = string.Format("Codice Code: {0} non valido", Code);
                throw new ArgumentException(messaggio);
            }

            //********* PRODUZIONE ******
            CertixDS ds = new CertixDS();
            CertixDS.USR_PRD_MOVFASIRow movFase = VerificaBarcodeODL(Code, ds);
            if (movFase == null)
            {
                string messaggio = string.Format("Codice Code: {0} non valido", Code);
                throw new ArgumentException(messaggio);
            }

            CertixDS.USR_PRD_FASIRow faseGalvanica = EstraiFaseGalvanicaDaODL(movFase, ds);
            if (faseGalvanica == null)
            {
                string messaggio = string.Format("Codice Code: {0} fase galvanica non trovata", Code);
                throw new ArgumentException(messaggio);
            }
            if (faseGalvanica.IsIDMAGAZZNull())
            {
                string messaggio = string.Format("Codice Code: {0} articolo galvanica non trovato", Code);
                throw new ArgumentException(messaggio);
            }
            int idMeasure = -1;
            using (CertixWSBusiness bCertix = new CertixWSBusiness())
            {
                bCertix.FillAP_GALVANICA_SPESSORI(ds, movFase.IDMAGAZZ, faseGalvanica.IDMAGAZZ);


                if (ds.AP_GALVANICA_SPESSORI.Count == 0)
                {
                    string messaggio = string.Format("Codice Code: {0} articolo galvanica dati incompleti", Code);
                    throw new ArgumentException(messaggio);
                }

                CertixDS.AP_CERTIXRow certixRow = ds.AP_CERTIX.NewAP_CERTIXRow();
                certixRow.IDMISURECERTIX = bCertix.GetID();
                idMeasure = (int)certixRow.IDMISURECERTIX;
                certixRow.IDLINE = IdLine;
                certixRow.BARCODE = Code;
                certixRow.IDMAGAZZ = movFase.IDMAGAZZ;
                certixRow.IDMAGAZZ_WIP = faseGalvanica.IDMAGAZZ;

                ds.AP_CERTIX.AddAP_CERTIXRow(certixRow);

                bCertix.UpdateTable(ds.AP_CERTIX.TableName, ds);

            }
            Measures = ds.AP_GALVANICA_SPESSORI.OrderBy(x => x.SEQUENZA).Select(x => x.ETICHETTA).ToList();
            return idMeasure;
        }

        private CertixDS.USR_PRD_MOVFASIRow VerificaBarcodeODL(string barcode, CertixDS ds)
        {
            using (CertixWSBusiness bCertix = new CertixWSBusiness())
            {
                bCertix.FillUSR_PRD_MOVFASIByBarcode(ds, barcode);
            }
            return ds.USR_PRD_MOVFASI.Where(x => x.BARCODE == barcode).FirstOrDefault();
        }


        private CertixDS.USR_PRD_FASIRow EstraiFaseGalvanicaDaODL(CertixDS.USR_PRD_MOVFASIRow movFase, CertixDS ds)
        {
            using (CertixWSBusiness bCertix = new CertixWSBusiness())
            {
                bCertix.FillUSR_PRD_FASI(ds, new List<string>(new string[] { movFase.IDPRDFASE }));

                CertixDS.USR_PRD_FASIRow fase = ds.USR_PRD_FASI.Where(x => x.IDPRDFASE == movFase.IDPRDFASE).FirstOrDefault();

                if (fase == null)
                {
                    string messaggio = string.Format("Nessuna fase trovata per IDPRDFASE: {0} ", movFase.IDPRDFASE);
                    throw new ArgumentException(messaggio);
                }
                if (fase.IsIDPRDFASEPADRENull())
                {
                    string messaggio = "Impossibile risalire alla fase di galvanica";
                    throw new ArgumentException(messaggio);
                }


                bCertix.FillUSR_PRD_FASI(ds, new List<string>(new string[] { fase.IDPRDFASEPADRE }));
                CertixDS.USR_PRD_FASIRow faseGalvanica = ds.USR_PRD_FASI.Where(x => x.IDPRDFASE == fase.IDPRDFASEPADRE).FirstOrDefault();
                if (faseGalvanica == null)
                {
                    string messaggio = "Nessuna fase galvanica non trovata per IDPRDFASE: " + fase.IDPRDFASEPADRE;
                    throw new ArgumentException(messaggio);
                }
                return faseGalvanica;
            }
        }

        public void RegistraMisure(int IdMeasure, List<UploadMeasuresElementRequest> UploadMeasuresElements, bool IsTest)
        {
            if (IsTest)
            {
                if (IdMeasure < 0)
                {
                    string messaggio = string.Format("IdMeasure: {0} non valido", IdMeasure);
                    throw new ArgumentException(messaggio);
                }
                return;
            }
            CertixDS ds = new CertixDS();
            if (!VerificaIdMeasure(IdMeasure, ds))
            {
                string messaggio = string.Format("IdMeasure: {0} non censito a sistema", IdMeasure);
                throw new ArgumentException(messaggio);
            }

            if (!VerificaDuplicati(IdMeasure, ds))
            {
                string messaggio = string.Format("IdMeasure: {0} misure già acquisite", IdMeasure);
                throw new ArgumentException(messaggio);
            }
            VerificaMuasures(IdMeasure, UploadMeasuresElements, ds);

            SalvaMuasures(IdMeasure, UploadMeasuresElements, ds);
        }

        private bool VerificaIdMeasure(int IdMeasure, CertixDS ds)
        {
            using (CertixWSBusiness bCertix = new CertixWSBusiness())
            {
                bCertix.FillAP_CERTIX(ds, IdMeasure);
                return ds.AP_CERTIX.Any(x => x.IDMISURECERTIX == IdMeasure);
            }
        }

        private bool VerificaDuplicati(int IdMeasure, CertixDS ds)
        {
            using (CertixWSBusiness bCertix = new CertixWSBusiness())
            {
                bCertix.FillAP_CERTIX_DETTAGLIO(ds, IdMeasure);
                return ds.AP_CERTIX_DETTAGLIO.Any(x => x.IDMISURECERTIX == IdMeasure);
            }
        }
        private void VerificaMuasures(int IdMeasure, List<UploadMeasuresElementRequest> UploadMeasuresElements, CertixDS ds)
        {
            bool esito = true;
            StringBuilder sb = new StringBuilder();

            CertixDS.AP_CERTIXRow misura = ds.AP_CERTIX.Where(x => x.IDMISURECERTIX == IdMeasure).FirstOrDefault();
            using (CertixWSBusiness bCertix = new CertixWSBusiness())
            {
                bCertix.FillAP_GALVANICA_SPESSORI(ds, misura.IDMAGAZZ, misura.IDMAGAZZ_WIP);
            }
            decimal aux;
            foreach (UploadMeasuresElementRequest m in UploadMeasuresElements)
            {
                if (m.Material.Length > 10)
                {
                    esito = false;
                    sb.AppendLine(string.Format("Materiale: {0} lunghezza etichetta non valida", m.Material));
                }

                if (!ds.AP_GALVANICA_SPESSORI.Select(x => x.ETICHETTA).ToList().Contains(m.Material))
                {
                    esito = false;
                    sb.AppendLine(string.Format("Materiale: {0} inatteso.", m.Material));
                }

            }

            if (!esito)
            {
                throw new ArgumentException(sb.ToString());
            }
        }

        private void SalvaMuasures(int IdMeasure, List<UploadMeasuresElementRequest> UploadMeasuresElements, CertixDS ds)
        {
            int sequenza = 0;
            using (CertixWSBusiness bCertix = new CertixWSBusiness())
            {
                foreach (UploadMeasuresElementRequest m in UploadMeasuresElements)
                {
                    CertixDS.AP_CERTIX_DETTAGLIORow dettaglio = ds.AP_CERTIX_DETTAGLIO.NewAP_CERTIX_DETTAGLIORow();
                    dettaglio.DATAINSERIMENTO = DateTime.Now;
                    dettaglio.ETICHETTA = m.Material;
                    dettaglio.IDMISURECERTIX = IdMeasure;
                    dettaglio.IDMISURECERTIXDET = bCertix.GetID();
                    dettaglio.SEQUENZA = sequenza;
                    sequenza++;
                    dettaglio.VALORE = m.Measure;
                    ds.AP_CERTIX_DETTAGLIO.AddAP_CERTIX_DETTAGLIORow(dettaglio);
                }
                bCertix.UpdateTable(ds.AP_CERTIX_DETTAGLIO.TableName, ds);

            }
        }
    }
}
