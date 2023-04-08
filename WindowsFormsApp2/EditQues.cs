using Mysqlx.Crud;
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
using System.Collections;

namespace WindowsFormsApp2
{
    public partial class EditQues : Form
    {
        string ID;
        string cur_description, cur_subject, cur_point, cur_type;
        string cur_A, cur_B, cur_C, cur_D, cur_choice;
        string new_choice;

        private void rbB_CheckedChanged(object sender, EventArgs e)
        {
            new_choice = rbB.Text;
        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            new_choice = rbC.Text;
        }

        private void rbD_CheckedChanged(object sender, EventArgs e)
        {
            new_choice = rbD.Text;
        }

        private void rbA_CheckedChanged(object sender, EventArgs e)
        {
            new_choice = rbA.Text;
        }

        SqlConnect sql = new SqlConnect();
        public EditQues(string ID, string description, string subject, string point, string type)
        {
            InitializeComponent();
            this.ID = ID;
            cur_description = description;
            cur_subject = subject;
            cur_point = point;
            cur_type = type;
        }
        public EditQues(string ID, string description, string subject, string point, string type, string A, string B, string C, string D, string choice)
        {
            InitializeComponent();
            this.ID = ID;
            cur_description = description;
            cur_subject = subject;
            cur_point = point;
            cur_type = type;
            cur_A = A;
            cur_B = B;
            cur_C = C;
            cur_D = D;
            cur_choice = choice;
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Ques_detail"].Show();
            this.Close();
        }
        private void EditQues_Load(object sender, EventArgs e)
        {
            tbDescription.Text = cur_description;
            tbSubject.Text = cur_subject;
            tbPoint.Text = cur_point;
            if (cur_type == "tự luận")
            {
                gbChoice.Hide();
            }
            else
            {
                tbA.Text = cur_A;
                tbB.Text = cur_B;
                tbC.Text = cur_C;
                tbD.Text = cur_D;
                switch (cur_choice)
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
                gbChoice.Show();
            }
        }
        private void btSubmit_Click(object sender, EventArgs e)
        {
            string query;
            if (cur_type == "trắc nghiệm")
            {
                query = String.Format("BEGIN TRANSACTION;" +
                "UPDATE question " +
                "SET question.Noi_dung = {0}, question.Hoc_phan = {1} FROM question, trac_nghiem " +
                "WHERE question.ID = trac_nghiem.ID_question AND question.ID = {2};" +

                "UPDATE trac_nghiem " +
                "SET trac_nghiem.A = {3}, trac_nghiem.B = {4}, trac_nghiem.C = {5}, trac_nghiem.D = {6}, trac_nghiem.Lua_chon = {7}, trac_nghiem.Diem = {8} " +
                "FROM question, trac_nghiem " +
                "WHERE question.ID = trac_nghiem.ID_question AND question.ID = {2};" +
                " COMMIT;", tbDescription.Text, tbSubject.Text, ID, tbA.Text, tbB.Text, tbC.Text, tbD.Text, new_choice, tbPoint.Text);
            }
            else
            {
                query = String.Format("BEGIN TRANSACTION;" +
                "UPDATE question " +
                "SET question.Noi_dung = {0}, question.Hoc_phan = {1} FROM question, tu_luan " +
                "WHERE question.ID = tu_luan.ID_question AND question.ID = {2};" +

                "UPDATE tu_luan " +
                "SET tu_luan.Diem = {3} " +
                "FROM question, tu_luan " +
                "WHERE question.ID = tu_luan.ID_question AND question.ID = {2};" +
                " COMMIT;", tbDescription.Text, tbSubject.Text, ID, tbPoint.Text);
            }
            using (SqlConnection con = sql.connectSQL())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
