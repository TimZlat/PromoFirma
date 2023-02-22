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

namespace PromoFirma.Forms
{
    public partial class frmMenager : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        //string StrConn = @"Data Source=MAM-PC\SQLEXPRESS;Integrated Security=True;Initial Catalog=PromoFirma;";
        string StrConn = @"Data Source=T215-3\SQLEXPRESS;Integrated Security=True;Initial Catalog=PromoFirma;";
        string sql = "SELECT * FROM z2_Sotr_Action;";
        string sqlF = "SELECT [Фамилия] FROM [Т_Сотрудник]";

        public frmMenager()
        {
            InitializeComponent();
           
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                //заполнение datagrid через адаптер
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgView.DataSource = ds.Tables[0].DefaultView;
                dgView.Columns[2].Visible = false;
                dgView.Columns[3].Visible = false;
                

                //SqlDataReader reader = command.ExecuteReader();


                //заполнение datagrid вручную
                //List<string[]> data = new List<string[]>();
                //while (reader.Read())
                //{
                //    data.Add(new string[6]);
                //    data[data.Count - 1][0] = reader[0].ToString();
                //    string N = reader[2].ToString();
                //    string O = reader[3].ToString();

                //    data[data.Count - 1][1] = reader[1].ToString() +" "+ N.Substring(0, 1)+". "+O.Substring(0,1)+"."; 

                //    //data[data.Count - 1][2] = reader[2].ToString();
                //    //data[data.Count - 1][3] = reader[3].ToString();

                //    data[data.Count - 1][2] = reader[4].ToString();
                //    data[data.Count - 1][3] = reader[5].ToString();
                //    data[data.Count - 1][4] = reader[6].ToString();
                //    data[data.Count - 1][5] = reader[7].ToString();
                //}
                //reader.Close();



                SqlCommand comm2 = new SqlCommand(sqlF, conn);
                SqlDataReader reader2 = comm2.ExecuteReader();
                while (reader2.Read())
                    cmbFam.Items.Add(reader2[0].ToString());
                 

                //dgView.Columns.Add("КодСотрудника", "Код сотрудника");
                //dgView.Columns.Add("Фамилия", "Фамилия И.О.");
                ////dgView.Columns.Add("Имя", "");
                ////dgView.Columns.Add("Отчество", "");
                //dgView.Columns.Add("НомерАкции", "Номер акции");
                //dgView.Columns.Add("НазваниеАкции", "Название акции");
                //dgView.Columns.Add("ТипАкции", "Тип акции");
                //dgView.Columns.Add("ДатаНачала", "Дата начала");

                //foreach (string[] s in data)
                //{
                //    dgView.Rows.Add(s);
                //}
                    
            }
            

        }
        

        private void frmMenager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmMain FMain = new frmMain();
            FMain.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlVyb = "SELECT * FROM z2_Sotr_Action ";
            if(cmbFam.Text!="")
            {
                sqlVyb = sqlVyb + "WHERE [Фамилия]='" + cmbFam.Text + "'";
                
            }

            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlVyb, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgView.DataSource = ds.Tables[0].DefaultView;

            }
        }

        private void cmbFam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlVyb = "SELECT * FROM z2_Sotr_Action ";
            if (cmbFam.Text != "")
            {
                sqlVyb = sqlVyb + "WHERE [Фамилия]='" + cmbFam.Text + "'";

            }

            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlVyb, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgView.DataSource = ds.Tables[0].DefaultView;

            }

        }
    }
}
