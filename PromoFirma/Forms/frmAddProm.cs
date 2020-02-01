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

namespace PromoFirma.Forms
{
    public partial class frmAddProm : Form

    {
       
        
        string StrConn = @"Data Source=MAM-PC\SQLEXPRESS;Integrated Security=True;Initial Catalog=PromoFirma;";
        DataSet ds = new DataSet();


        public frmAddProm()
        {

            InitializeComponent();
        }

        private void frmAddProm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmMain Fmain = new frmMain();
            Fmain.ShowDialog();
                
        }

        private void btnInpt_Click(object sender, EventArgs e)
        {
           
            string SqlSel = "SELECT * FROM [Т_Сотрудник] WHERE [Логин]='" + txtLog.Text + "' AND [Пароль]='" + txtPass.Text + "';";
            try
            {
                using (SqlConnection conn = new SqlConnection(StrConn))
                {
                    conn.Open();
                    
                    SqlCommand command = new SqlCommand(SqlSel, conn);
                    SqlDataReader reader1 = command.ExecuteReader();
                    if (reader1.HasRows)
                        MessageBox.Show("Пользователь с таким логином уже существует!");
                    conn.Close();
                    conn.Open();
                    string Fam = txtFam.Text;
                    string Im = txtName.Text;
                    string Otch = txtOtch.Text;
                    string Log = txtLog.Text;
                    string Pass = txtPass.Text;
                    string SqlIns = @"INSERT INTO [Т_Сотрудник] ([КодРоли],[Фамилия],[Имя]," +
             "[Отчество],[Логин],[Пароль],[ДатаРождения],[Телефон])" +
             "VALUES(" + Convert.ToUInt32("3") + ",'" + Fam + "','" + Im +
             "','" + Otch + "','" + Log + "','" + Pass + "','" + 
             Convert.ToDateTime("2020/05/01") + "','" + txtTel.Text + "')";
                    SqlCommand command1 = new SqlCommand(SqlIns, conn);
                    int number = command1.ExecuteNonQuery();
                    MessageBox.Show("Таблица T_Сотрудники обновлена" + "\n" +
                        "Добавлено " + number.ToString() + " записей");
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show("Произошла ошибка - " + exp.ToString());
            }
        }
    }
}
