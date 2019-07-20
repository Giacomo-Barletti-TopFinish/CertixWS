using CertixWS.BLL;
using CertixWS.Data;
using CertixWS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApplication
{
    public partial class InserimentoDatiFrm : Form
    {
        private CertixDS _ds = new CertixDS();
        public InserimentoDatiFrm()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string brand = (string)ddlBrand.SelectedItem;
            if (string.IsNullOrEmpty(brand))
            {
                lblMessaggio.Text = "Brand non valorizzato";
                return;
            }

            if (string.IsNullOrEmpty(txtFinitura.Text))
            {
                lblMessaggio.Text = "Finitura non valorizzata";
                return;
            }

            if (dgvEtichette.Rows.Count == 0)
            {
                lblMessaggio.Text = "Etichette non inserite";
                return;
            }

            using (CertixWSBusiness bCertix = new CertixWSBusiness())
            {
                CertixDS.AP_GALVANICA_MODELLORow modello = _ds.AP_GALVANICA_MODELLO.Where(x => x.IDMAGAZZ == txtIdmagazz.Text && x.IDMAGAZZ_WIP == txtIdmagazzWip.Text).FirstOrDefault();
                if (modello == null)
                {
                    CertixDS.AP_GALVANICA_MODELLORow galvanicaModello = _ds.AP_GALVANICA_MODELLO.NewAP_GALVANICA_MODELLORow();
                    galvanicaModello.IDGALVAMODEL = bCertix.GetID();
                    galvanicaModello.IDMAGAZZ = txtIdmagazz.Text;
                    galvanicaModello.IDMAGAZZ_WIP = txtIdmagazzWip.Text;
                    galvanicaModello.MODELLO = txtModelloMagazz.Text;
                    galvanicaModello.COMPONENTE = txtModelloMagazzWip.Text;
                    galvanicaModello.BRAND = brand;
                    galvanicaModello.FINITURA = txtFinitura.Text;

                    _ds.AP_GALVANICA_MODELLO.AddAP_GALVANICA_MODELLORow(galvanicaModello);

                }

                List<CertixDS.AP_GALVANICA_SPESSORIRow> elementi = _ds.AP_GALVANICA_SPESSORI.Where(x => x.BRAND == brand && x.FINITURA == txtFinitura.Text).ToList();
                foreach (CertixDS.AP_GALVANICA_SPESSORIRow elemento in elementi) elemento.Delete();

                int sequenza = 0;
                foreach (DataGridViewRow dr in dgvEtichette.Rows)
                {
                    if (dr.IsNewRow) continue;
                    CertixDS.AP_GALVANICA_SPESSORIRow spessore = _ds.AP_GALVANICA_SPESSORI.NewAP_GALVANICA_SPESSORIRow();
                    spessore.IDGALVASPESSORI = bCertix.GetID();
                    spessore.BRAND = brand;
                    spessore.FINITURA = txtFinitura.Text;
                    spessore.SEQUENZA = sequenza;
                    sequenza++;
                    spessore.ETICHETTA = (string)dr.Cells[0].Value;
                    _ds.AP_GALVANICA_SPESSORI.AddAP_GALVANICA_SPESSORIRow(spessore);
                }

                bCertix.UpdateTable(_ds.AP_GALVANICA_MODELLO.TableName, _ds);
                bCertix.UpdateTable(_ds.AP_GALVANICA_SPESSORI.TableName, _ds);
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barcode = textBox1.Text;
                using (CertixWSBusiness bCertix = new CertixWSBusiness())
                {
                    CertixBLL bll = new CertixBLL();
                    CertixDS.USR_PRD_MOVFASIRow movFase = bll.VerificaBarcodeODL(barcode, _ds);
                    if (movFase == null)
                    {
                        string messaggio = string.Format("Codice Code: {0} non valido", barcode);
                        throw new ArgumentException(messaggio);
                    }
                    txtIdmagazz.Text = movFase.IsIDMAGAZZNull() ? string.Empty : movFase.IDMAGAZZ;
                    if (!movFase.IsIDMAGAZZNull())
                    {
                        bCertix.FillMAGAZZ(_ds, movFase.IDMAGAZZ);
                        CertixDS.MAGAZZRow magazz = _ds.MAGAZZ.Where(x => x.IDMAGAZZ == movFase.IDMAGAZZ).FirstOrDefault();
                        if (magazz != null)
                        {
                            txtModelloMagazz.Text = magazz.MODELLO;
                        }
                    }

                    CertixDS.USR_PRD_FASIRow faseGalvanica = bll.EstraiFaseGalvanicaDaODL(movFase, _ds);
                    if (faseGalvanica == null)
                    {
                        string messaggio = string.Format("Codice Code: {0} fase galvanica non trovata", barcode);
                        throw new ArgumentException(messaggio);
                    }
                    if (faseGalvanica.IsIDMAGAZZNull())
                    {
                        string messaggio = string.Format("Codice Code: {0} articolo galvanica non trovato", barcode);
                        throw new ArgumentException(messaggio);
                    }
                    else
                    {
                        bCertix.FillMAGAZZ(_ds, faseGalvanica.IDMAGAZZ);
                        CertixDS.MAGAZZRow magazz = _ds.MAGAZZ.Where(x => x.IDMAGAZZ == faseGalvanica.IDMAGAZZ).FirstOrDefault();
                        if (magazz != null)
                        {
                            txtModelloMagazzWip.Text = magazz.MODELLO;
                        }

                    }
                    txtIdmagazzWip.Text = faseGalvanica.IsIDMAGAZZNull() ? string.Empty : faseGalvanica.IDMAGAZZ;


                    bCertix.FillAP_GALVANICA_MODELLO(_ds, movFase.IDMAGAZZ, faseGalvanica.IDMAGAZZ);


                    if (_ds.AP_GALVANICA_MODELLO.Count != 0)
                    {
                        CertixDS.AP_GALVANICA_MODELLORow modello = _ds.AP_GALVANICA_MODELLO.Where(x => x.IDMAGAZZ == txtIdmagazz.Text && x.IDMAGAZZ_WIP == txtIdmagazzWip.Text).FirstOrDefault();
                        if (modello != null)
                        {
                            ddlBrand.Text = modello.IsBRANDNull() ? string.Empty : modello.BRAND;
                            txtFinitura.Text = modello.IsFINITURANull() ? string.Empty : modello.FINITURA;
                            bCertix.FillAP_GALVANICA_SPESSORI(ddlBrand.Text, txtFinitura.Text, _ds);
                            List<string> etichette = _ds.AP_GALVANICA_SPESSORI.OrderBy(x => x.SEQUENZA).Select(x => x.ETICHETTA).ToList();
                            foreach (string etichetta in _ds.AP_GALVANICA_SPESSORI.OrderBy(x => x.SEQUENZA).Select(x => x.ETICHETTA).ToList())
                                dgvEtichette.Rows.Add(etichetta);

                        }
                    }
                }
            }
        }

        private string[] CreaListaBrand()
        {
            List<string> brand = new List<string>();
            brand.Add("YSL");
            brand.Add("CHANEL");
            brand.Add("BALENCIAGA");
            brand.Add("GUCCI");
            brand.Add("LOUIS VUITTON");
            brand.Add("BOTTEGA VENETA");
            brand.Add("TOM FORD");
            brand.Add("FENDI");
            brand.Add("MONTBLANC");
            brand.Add("CELINE");
            brand.Add("ALCE");

            brand.Sort();
            return brand.ToArray();
        }

        private void InserimentoDatiFrm_Load(object sender, EventArgs e)
        {
            lblMessaggio.Text = string.Empty;
            ddlBrand.Items.AddRange(CreaListaBrand());
        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            txtFinitura.Text = string.Empty;
            txtIdmagazz.Text = string.Empty;
            txtIdmagazzWip.Text = string.Empty;
            txtModelloMagazz.Text = string.Empty;
            txtModelloMagazzWip.Text = string.Empty;
            ddlBrand.SelectedItem = string.Empty;
            dgvEtichette.Rows.Clear();
        }
    }
}
