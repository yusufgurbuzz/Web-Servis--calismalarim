using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace formlistele
{
    public partial class frmListele : Form
    {
        public frmListele()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1SoapClient sc = new ServiceReference1.Service1SoapClient();
            dataGrd.DataSource=sc.getir();
        }
    }
}
