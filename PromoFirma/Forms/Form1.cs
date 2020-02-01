using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PromoFirma.Forms;

namespace PromoFirma
{
    public partial class frmMain : Form
    {
        string conString = @"Data Source=MAM-PC\SQLEXPRESS;Integrated Security=True;Initial Catalog=PromoFirma;";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!(txtLog.Text.Equals("")||(txtPassw.Text.Equals(""))))
            {
                string SqlCom = "SELECT [Логин],[Пароль],[КодРоли] FROM [z1_Sotr_Roli] WHERE ([Логин]='"
                    + txtLog.Text + "' AND [Пароль]='" + txtPassw.Text + "')";
                using (SqlConnection Conn = new SqlConnection(conString))
                {
                    Conn.Open();
                    SqlCommand command = new SqlCommand(SqlCom, Conn);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                       while(reader.Read())
                        {
                            object Login = reader.GetValue(0);
                            object Passw = reader.GetValue(1);
                            object IdRole = reader.GetValue(2);
                            MessageBox.Show(Login + " " + Passw + " " + IdRole);
                            FormRedirect(Convert.ToInt32(IdRole));
                        }
                        
                    }
                    else
                        MessageBox.Show("Неверный логин или пароль");
                }
            }
        }
        public void FormRedirect(int role)
        {
            switch(role)
            {
                case 1:
                    this.Hide();
                    frmMenager FM = new frmMenager();
                    FM.ShowDialog();
                    break;
                case 2:
                    this.Hide();
                    frmSupervizer FS = new frmSupervizer();
                    FS.ShowDialog();
                    break;
                case 3:
                    this.Hide();
                    frmPromouter FP = new frmPromouter();
                    FP.ShowDialog();
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddProm frmAdd = new frmAddProm();
            frmAdd.ShowDialog();
        }
    }
}
