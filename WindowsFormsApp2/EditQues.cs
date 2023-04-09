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
            tbType.Text = cur_type;
            if (cur_type.Equals("tự luận", StringComparison.OrdinalIgnoreCase))
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
            using (SqlConnection con = sql.connectSQL())
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    if (cur_type.Equals("trắc nghiệm", StringComparison.OrdinalIgnoreCase))
                    {
                        cmd.CommandText = "BEGIN TRANSACTION;\n" +
                        "UPDATE question " +
                        "SET question.Noi_dung = @description, question.Hoc_phan = @subject FROM question, trac_nghiem " +
                        "WHERE question.ID = trac_nghiem.ID_question AND question.ID = @ID;\n\n" +

                        "UPDATE trac_nghiem " +
                        "SET trac_nghiem.A = @A, trac_nghiem.B = @B, trac_nghiem.C = @C, trac_nghiem.D = @D, trac_nghiem.Lua_chon = @choice, trac_nghiem.Diem = @point " +
                        "FROM question, trac_nghiem " +
                        "WHERE question.ID = trac_nghiem.ID_question AND question.ID = @ID;\n" +
                        "COMMIT;";
                        cmd.Parameters.AddWithValue("@A", tbA.Text);
                        cmd.Parameters.AddWithValue("@B", tbB.Text);
                        cmd.Parameters.AddWithValue("@C", tbC.Text);
                        cmd.Parameters.AddWithValue("@D", tbD.Text);
                        cmd.Parameters.AddWithValue("@choice", new_choice);

                    }
                    else
                    {
                        cmd.CommandText = "BEGIN TRANSACTION;\n" +
                        "UPDATE question " +
                        "SET question.Noi_dung = @description, question.Hoc_phan = @subject FROM question, tu_luan " +
                        "WHERE question.ID = tu_luan.ID_question AND question.ID = @ID;\n\n" +

                        "UPDATE tu_luan " +
                        "SET tu_luan.Diem = @point FROM question, tu_luan " +
                        "WHERE question.ID = tu_luan.ID_question AND question.ID = @ID;\n" +
                        " COMMIT;";
                    }
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@description", tbDescription.Text);
                    cmd.Parameters.AddWithValue("@point", tbPoint.Text);
                    cmd.Parameters.AddWithValue("@subject", tbSubject.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thay đổi thông tin thành công\n", "", MessageBoxButtons.OK);
                }
            }
        }
    }
}
