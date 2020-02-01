using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromoFirma.Forms
{
    public partial class frmPromouter : Form
    {
        public frmPromouter()
        {
            InitializeComponent();
        }

        private void frmPromouter_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmMain FMain = new frmMain();
            FMain.ShowDialog();
        }
    }
}
