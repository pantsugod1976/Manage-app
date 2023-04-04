using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.IO.Pipes;

namespace WindowsFormsApp2
{
    public partial class AddQuestion : Form
    {
        private char answer;
        public AddQuestion()
        {
            InitializeComponent();
        }
        SqlConnect sqlConnect = new SqlConnect();
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void AddQuestion_Load(object sender, EventArgs e)
        {
            gbChoice.Hide();
        }

        private void gbType_Enter(object sender, EventArgs e)
        {

        }

        private void rbChoice_CheckedChanged(object sender, EventArgs e)
        {
            gbChoice.Visible = true;
            rbA.Checked = true;
        }

        private void Insert_Question(MySqlConnection conn)
        {
            string id = "";
            string query_ques = ("INSERT INTO question(Noi_dung, Hoc_phan, Kieu_cau_hoi) VALUES (@description, @subject, @type)");
            if (rbChoice.Checked)
            {    
                using (MySqlCommand cmd = new MySqlCommand(query_ques, conn))
                {
                    cmd.Parameters.AddWithValue("@description", tbDescription.Text);
                    cmd.Parameters.AddWithValue("@subject", tbSubject.Text);
                    cmd.Parameters.AddWithValue("@type", rbChoice.Text);
                    cmd.ExecuteNonQuery();
                }
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM question ORDER BY ID DESC LIMIT 1", conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        id = reader["ID"].ToString(); 
                    }
                }
                string query_TN = "INSERT INTO trac_nghiem VALUES (@ID, @A, @B, @C, @D, @answer, @point)";
                using (MySqlCommand cmd = new MySqlCommand(query_TN, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@A", tbA.Text);
                    cmd.Parameters.AddWithValue("@B", tbB.Text);
                    cmd.Parameters.AddWithValue("@C", tbC.Text);
                    cmd.Parameters.AddWithValue("@D", tbD.Text);
                    cmd.Parameters.AddWithValue("@answer", answer);
                    cmd.Parameters.AddWithValue("@point", tbPoint.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                using (MySqlCommand cmd = new MySqlCommand(query_ques, conn))
                {
                    cmd.Parameters.AddWithValue("@description", tbDescription.Text);
                    cmd.Parameters.AddWithValue("@subject", tbSubject.Text);
                    cmd.Parameters.AddWithValue("@type", rbEssay.Text);
                    cmd.ExecuteNonQuery();
                }
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM question ORDER BY ID DESC LIMIT 1", conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        id = reader["ID"].ToString();
                    }
                }
                string query_TL = "INSERT INTO tu_luan VALUES (@ID, @point)";
                using (MySqlCommand cmd = new MySqlCommand(query_TL, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("point", tbPoint.Text);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDescription.Text))
            {
                MessageBox.Show("Description cannot be empty", "Error description", MessageBoxButtons.OK);
                tbDescription.Focus();
                return;
            }
            if (rbChoice.Checked)
            {
                if (tbA.Text == "" || tbB.Text == "" || tbC.Text == "" || tbD.Text == "")
                {
                    MessageBox.Show("Empty choice", "", MessageBoxButtons.OK);
                    tbA.Focus();
                    return;
                }
            }
            if (string.IsNullOrEmpty(tbSubject.Text))
            {
                MessageBox.Show("Subject cannot be empty", "Error subject", MessageBoxButtons.OK);
                tbSubject.Focus();
                return;
            }
            bool successfullyParsed = float.TryParse(tbPoint.Text, out float res);
            if (!successfullyParsed)
            {
                MessageBox.Show("Diem khong hop le", "", MessageBoxButtons.OK);
                tbPoint.Focus();
                return;
            }
            using (MySqlConnection con = sqlConnect.connectSQL())
            {
                con.Open();
                Insert_Question(con);
            }
            MessageBox.Show("Add question successfull", "", MessageBoxButtons.OK);
        }

        private void rbEssay_CheckedChanged(object sender, EventArgs e)
        {
            gbChoice.Hide();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["HomePage"];
            frm.Show();
            this.Close();
        }

        private void rbA_CheckedChanged(object sender, EventArgs e)
        {
            answer = 'A';
        }

        private void rbB_CheckedChanged(object sender, EventArgs e)
        {
            answer = 'B';
        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            answer = 'C';
        }

        private void rbD_CheckedChanged(object sender, EventArgs e)
        {
            answer = 'D';
        }

        private void tbPoint_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
