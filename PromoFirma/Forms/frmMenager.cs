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
        string StrConn = @"Data Source=MAM-PC\SQLEXPRESS;Integrated Security=True;Initial Catalog=PromoFirma;";
        string sql = "SELECT * FROM z2_Sotr_Action;";

        public frmMenager()
        {
            InitializeComponent();
           
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[6]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    string N = reader[2].ToString();
                    string O = reader[3].ToString();

                    data[data.Count - 1][1] = reader[1].ToString() +" "+ N.Substring(0, 1)+". "+O.Substring(0,1)+"."; 
                    
                    //data[data.Count - 1][2] = reader[2].ToString();
                    //data[data.Count - 1][3] = reader[3].ToString();

                    data[data.Count - 1][2] = reader[4].ToString();
                    data[data.Count - 1][3] = reader[5].ToString();
                    data[data.Count - 1][4] = reader[6].ToString();
                    data[data.Count - 1][5] = reader[7].ToString();
                }
                reader.Close();

                dgView.Columns.Add("КодСотрудника", "Код сотрудника");
                dgView.Columns.Add("Фамилия", "Фамилия И.О.");
                //dgView.Columns.Add("Имя", "");
                //dgView.Columns.Add("Отчество", "");
                dgView.Columns.Add("НомерАкции", "Номер акции");
                dgView.Columns.Add("НазваниеАкции", "Название акции");
                dgView.Columns.Add("ТипАкции", "Тип акции");
                dgView.Columns.Add("ДатаНачала", "Дата начала");

                foreach (string[] s in data)
                    dgView.Rows.Add(s);
            }
            

        }
        

        private void frmMenager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmMain FMain = new frmMain();
            FMain.ShowDialog();
        }

       
    }
}
