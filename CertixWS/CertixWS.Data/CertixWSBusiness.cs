using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CertixWS.Data.Core;
using CertixWS.Entities;

namespace CertixWS.Data
{
    public class CertixWSBusiness : CertixWSBusinessBase
    {
        public CertixWSBusiness() : base() { }

        [DataContext]
        public void FillUSR_PRD_MOVFASI(CertixDS ds, List<string> IDPRDMOVFASE)
        {
            List<string> Presenti = ds.USR_PRD_MOVFASI.Select(x => x.IDPRDMOVFASE).Distinct().ToList();
            List<string> Mancanti = IDPRDMOVFASE.Except(Presenti).ToList();

            CertixWSAdapter a = new CertixWSAdapter(DbConnection, DbTransaction);
            while (Mancanti.Count > 0)
            {
                List<string> daCaricare;
                if (Mancanti.Count > 999)
                {
                    daCaricare = Mancanti.GetRange(0, 999);
                    Mancanti.RemoveRange(0, 999);
                }
                else
                {
                    daCaricare = Mancanti.GetRange(0, Mancanti.Count);
                    Mancanti.RemoveRange(0, Mancanti.Count);
                }
                a.FillUSR_PRD_MOVFASI(ds, daCaricare);
            }
        }

        [DataContext]
        public void FillUSR_PRD_FASI(CertixDS ds, List<string> IDPRDFASE)
        {
            List<string> Presenti = ds.USR_PRD_FASI.Select(x => x.IDPRDFASE).Distinct().ToList();
            List<string> Mancanti = IDPRDFASE.Except(Presenti).ToList();

            CertixWSAdapter a = new CertixWSAdapter(DbConnection, DbTransaction);
            while (Mancanti.Count > 0)
            {
                List<string> daCaricare;
                if (Mancanti.Count > 999)
                {
                    daCaricare = Mancanti.GetRange(0, 999);
                    Mancanti.RemoveRange(0, 999);
                }
                else
                {
                    daCaricare = Mancanti.GetRange(0, Mancanti.Count);
                    Mancanti.RemoveRange(0, Mancanti.Count);
                }
                a.FillUSR_PRD_FASI(ds, daCaricare);
            }
        }

        [DataContext]
        public void FillUSR_PRD_MOVFASIByBarcode(CertixDS ds, string Barcode)
        {
            CertixWSAdapter a = new CertixWSAdapter(DbConnection, DbTransaction);
            a.FillUSR_PRD_MOVFASIByBarcode(ds, Barcode);
        }

        [DataContext]
        public void FillMAGAZZ(CertixDS ds, List<string> IDMAGAZZ)
        {
            CertixWSAdapter a = new CertixWSAdapter(DbConnection, DbTransaction);
            a.FillMAGAZZ(ds, IDMAGAZZ);
        }

        [DataContext]
        public void FillMAGAZZ(CertixDS ds, string IDMAGAZZ)
        {
            FillMAGAZZ(ds, new List<string>(new string[] { IDMAGAZZ }));
        }

        [DataContext]
        public void FillAP_CERTIX(CertixDS ds, decimal IDMISURECERTIX)
        {
            CertixWSAdapter a = new CertixWSAdapter(DbConnection, DbTransaction);
            a.FillAP_CERTIX(ds, IDMISURECERTIX);
        }

        [DataContext]
        public void FillAP_GALVANICA_SPESSORI(CertixDS ds, string IDMAGAZZ, string IDMAGAZZ_WIP)
        {
            CertixWSAdapter a = new CertixWSAdapter(DbConnection, DbTransaction);
            a.FillAP_GALVANICA_SPESSORI(ds, IDMAGAZZ, IDMAGAZZ_WIP);
        }

        [DataContext(true)]
        public void UpdateTable(string tablename, CertixDS ds)
        {
            CertixWSAdapter a = new CertixWSAdapter(DbConnection, DbTransaction);
            a.UpdateTable(tablename, ds);
        }

        [DataContext]
        public void FillAP_CERTIX_DETTAGLIO(CertixDS ds, decimal IDMISURECERTIX)
        {
            CertixWSAdapter a = new CertixWSAdapter(DbConnection, DbTransaction);
            a.FillAP_CERTIX_DETTAGLIO(ds, IDMISURECERTIX);
        }

        [DataContext]
        public void FillAP_GALVANICA_MODELLO(CertixDS ds, string IDMAGAZZ, string IDMAGAZZ_WIP)
        {
            CertixWSAdapter a = new CertixWSAdapter(DbConnection, DbTransaction);
            a.FillAP_GALVANICA_MODELLO(ds, IDMAGAZZ, IDMAGAZZ_WIP);
        }

        [DataContext]
        public void FillAP_GALVANICA_SPESSORI(string Brand, string Finitura, CertixDS ds)
        {
            CertixWSAdapter a = new CertixWSAdapter(DbConnection, DbTransaction);
            a.FillAP_GALVANICA_SPESSORI(Brand, Finitura, ds);
        }
    }
}
