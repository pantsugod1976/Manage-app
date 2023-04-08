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
        string ID;
        string Lua_chon;
        SqlConnect sql = new SqlConnect();
        public Ques_detail(string id, string t)
        {
            InitializeComponent();
            ID = id;
            tbType.Text = t;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["ManageQues"].Show();
        }

        private void getDetail()
        {
            string query;
            if (tbType.Text == "Trắc nghiệm")
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
                        while (reader.Read())
                        {
                            tbDescription.Text = reader["Noi_dung"].ToString();
                            tbSubject.Text = reader["Hoc_phan"].ToString();
                            tbType.Text = reader["Kieu_cau_hoi"].ToString();
                            tbPoint.Text = reader["Diem"].ToString();
                            if (tbType.Text == "Trắc nghiệm")
                            {
                                tbA.Text = reader["A"].ToString();
                                tbB.Text = reader["B"].ToString();
                                tbC.Text = reader["C"].ToString();
                                tbD.Text = reader["D"].ToString();
                                Lua_chon = reader["Lua_chon"].ToString();
                            }
                        }
                   }
                }
            }
        }
        private void Ques_detail_Load(object sender, EventArgs e)
        {
            getDetail();
            if(tbType.Text == "tự luận")
                gbChoice.Hide();
            else 
            {
                gbChoice.Show();
                switch (Lua_chon)
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
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            EditQues frm;
            if(tbType.Text == "tự luận")
            {
               frm = new EditQues(ID, tbDescription.Text, tbSubject.Text, tbPoint.Text, tbType.Text);
            }
            else
            {
               frm = new EditQues(ID, tbDescription.Text, tbSubject.Text, tbPoint.Text, tbType.Text, tbA.Text, tbB.Text, tbC.Text, tbD.Text, Lua_chon);
            }
            frm.Show();
            this.Hide();
        }
    }
}
