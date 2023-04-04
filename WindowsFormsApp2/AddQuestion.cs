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
        private bool type;
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
            type = false;
            rbA.Checked = true;
        }

        private void Insert_Question(MySqlConnection conn)
        {
            if(rbChoice.Checked)
            {
                string query_ques = string.Format("INSERT INTO question(Noi_dung, Hoc_phan, Kieu_cau_hoi) VALUES {0}, {1}, {2}", tbDescription.Text, tbSubject.Text, rbChoice.Text);
                string query_choice = string.Format("INSERT INTO trac_nghiem() VALUES {0}, {1}, {2}, {3}, {4}, {5}", tbA.Text, tbB.Text, tbC.Text, tbD.Text, answer);
                using (MySqlCommand cmd = new MySqlCommand(query_ques, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                string query = string.Format("INSERT INTO tu_luan VALUES {0}, {1}, {2}, {3}, {4}, {5}", tbA.Text, tbB.Text, tbC.Text, tbD.Text, answer);
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
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
            
            using (MySqlConnection con = sqlConnect.connectSQL())
            {
                Insert_Question(con);
            }
        }

        private void rbEssay_CheckedChanged(object sender, EventArgs e)
        {
            gbChoice.Hide();
            type = true;
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
    } 
}
