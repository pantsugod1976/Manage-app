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

namespace WindowsFormsApp2
{
    public partial class AddQuestion : Form
    {
        bool type;
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

        private void btSubmit_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = MySqlUlities.GetDBMySqlConnect())
            {
                String query = "INSERT INTO question (Description,Type,Subject) VALUES (@description,@type,@subject)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@description", tbDescription.Text);
                    command.Parameters.AddWithValue("@type", type.ToString());
                    command.Parameters.AddWithValue("@subject", tbSubject.Text);
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                    else
                    {
                        MessageBox.Show("Successfull", "Insert data", MessageBoxButtons.OK);
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
            frm.Enabled = true;
            frm.Show();
        }
    }
}
