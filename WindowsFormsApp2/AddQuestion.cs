using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_Connect;
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
        }

        private void Insert_Answer(MySqlConnection conn, int ID)
        {
            string query = string.Format("INSERT INTO trac_nghiem VALUES {0}, {1}, {2}, {3}, {4}, {5}", tbA.Text, tbB.Text, tbC.Text, tbD.Text, answer);
            using(MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = MySqlUlities.GetDBMySqlConnect())
            {
                string query = "INSERT INTO question (Description,Type,Subject) VALUES (@description,@type,@subject)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@description", tbDescription.Text);
                    command.Parameters.AddWithValue("@type", type.ToString());
                    command.Parameters.AddWithValue("@subject", tbSubject.Text);
                    connection.Open();
                    /*if (type == false)
                    {
                        MySqlDbType.VarChar str;
                        str = tbDescription.Text;
                        string query_ID = "SELECT ID FROM question where Description = \"@description\"";
                        MySqlCommand cmd_ID = new MySqlCommand(query_ID, connection);
                        cmd_ID.Parameters.Add("@description", str);
                        int ID_question = cmd_ID.ExecuteNonQuery();
                        Insert_Answer(connection, ID_question);
                    }*/
                    int result = command.ExecuteNonQuery();
                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                    else
                    {
                        MessageBox.Show("Successfull", "Insert data", MessageBoxButtons.OK);
                        connection.Close();
                    }
                }
            }
        }

        private void rbEssay_CheckedChanged(object sender, EventArgs e)
        {
            gbChoice.Hide();
            type = true;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage frm = new HomePage();
            frm.Visible = true;
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
