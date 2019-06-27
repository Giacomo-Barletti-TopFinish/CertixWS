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
        }

        private void btnAcquisisceMisure_Click(object sender, EventArgs e)
        {

        }
    }
}
