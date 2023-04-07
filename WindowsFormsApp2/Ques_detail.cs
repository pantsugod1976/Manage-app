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

namespace WindowsFormsApp2
{
    public partial class Ques_detail : Form
    {
        int ID;
        string type;
        SqlConnect sql = new SqlConnect();
        public Ques_detail(string id, string t)
        {
            InitializeComponent();
            Int32.TryParse(id, out ID);
            type = t;
            tbType.Text = type;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["ManageQues"].Show();
        }

        private void getDetail()
        {
            string query;
            if (type.Equals("Trắc nghiệm"))
            {
                query = "SELECT question.Noi_dung, question.Hoc_phan, question.Kieu_cau_hoi, " +
                    "trac_nghiem.A, trac_nghiem.B, trac_nghiem.C, trac_nghiem.D, trac_nghiem.Lua_chon, trac_nghiem.Diem " +
                    "FROM question INNER JOIN trac_nghiem " +
                    "ON trac_nghiem.ID_question = question.ID WHERE trac_nghiem.ID_question = " + ID
                   ;
            }
            else
            {
                query = "SELECT question.Noi_dung, question.Hoc_phan, question.Kieu_cau_hoi, " +
                   "tu_luan.Diem " +
                   "FROM question LEFT JOIN tu_luan" +
                   " ON question.ID = tu_luan.ID_question WHERE tu_luan.ID_question = " + ID
                  ;
            }
            using (SqlConnection conn = sql.connectSQL())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                   using (SqlDataReader reader = cmd.ExecuteReader())
                   {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("hello" + reader["Noi_dung"].ToString());
                        }
                        //tbDescription.Text = reader.GetString(1);
                        /*tbSubject.Text = reader["Hoc_phan"].ToString();
                        tbPoint.Text = reader["Diem"].ToString();
                        if (tbType.Equals("Trắc nghiệm"))
                        {
                            tbA.Text = reader["A"].ToString();
                            tbB.Text = reader["B"].ToString();
                            tbC.Text = reader["C"].ToString();
                            tbD.Text = reader["D"].ToString();
                            switch (reader["Lua_chon"].ToString())
                            {
                                case "A":
                                    rbA.Checked = true;
                                    break;
                                case "B":
                                    rbB.Checked = true;
                                    break;
                                case "C":
                                    rbC.Checked = true;
                                    break;
                                case "D":
                                    rbD.Checked = true;
                                    break;
                            }
                        }*/
                   }
                }
            }
        }
        private void Ques_detail_Load(object sender, EventArgs e)
        {
            getDetail();
        }
    }
}
