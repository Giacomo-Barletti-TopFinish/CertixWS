using CertixWS.Common;
using CertixWS.Models;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMetodoTest_Click(object sender, EventArgs e)
        {
            CertixWS.CertixServicesSoapClient client = new CertixWS.CertixServicesSoapClient();
            txtMessaggio.Text = client.TestMethod();
        }

        private void btnAcquisiceCodice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                txtMessaggio.Text = "Il campo code non può essere vuoto";
                return;
            }
            CertixWS.CertixServicesSoapClient client = new CertixWS.CertixServicesSoapClient();
            txtMessaggio.Text = client.UploadCode((int)nIdLine.Value, txtCode.Text);
        }

        private void btnAcquisisceMisure_Click(object sender, EventArgs e)
        {
            List<UploadMeasuresElementRequest> measures = new List<UploadMeasuresElementRequest>();
            UploadMeasuresElementRequest e1 = new UploadMeasuresElementRequest();
            e1.Material = txtMaterial1.Text;
            e1.Measure = (float)nMeasure1.Value;
            measures.Add(e1);

            UploadMeasuresElementRequest e2 = new UploadMeasuresElementRequest();
            e2.Material = txtMaterial2.Text;
            e2.Measure = (float)nMeasure2.Value;
            measures.Add(e2);

            UploadMeasuresElementRequest e3 = new UploadMeasuresElementRequest();
            e3.Material = txtMaterial3.Text;
            e3.Measure = (float)nMeasure3.Value;
            measures.Add(e3);

            string json = JSonSerializer.Serialize<List<UploadMeasuresElementRequest>>(measures);

            CertixWS.CertixServicesSoapClient client = new CertixWS.CertixServicesSoapClient();
            txtMessaggio.Text = client.UploadMeasures((int)nIdMeasure.Value, json);
        }
    }
}
