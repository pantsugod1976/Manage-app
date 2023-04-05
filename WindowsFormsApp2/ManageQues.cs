using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx;

namespace WindowsFormsApp2
{
    public partial class ManageQues : Form
    {
        public ManageQues()
        {
            InitializeComponent();
        }
        SqlConnect sqlConnect = new SqlConnect();
        private void ManageQues_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM question";
            DataTable table = new DataTable();
            using (MySqlConnection conn = sqlConnect.connectSQL())
            {
                conn.Open();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    adapter.Fill(table);
                }
                dataGridView.DataSource = table;
            }
            DataGridViewButtonColumn col_detail = new DataGridViewButtonColumn();
            col_detail.UseColumnTextForButtonValue = true;
            col_detail.Text = "Detail";
            col_detail.Name = "Chi tiet";
            dataGridView.Columns.Add(col_detail);
            DataGridViewButtonColumn col_delete = new DataGridViewButtonColumn();
            col_delete.Text = "Delete";
            col_delete.Name = "Xoa";
            dataGridView.Columns.Add(col_delete);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["HomePage"];
            frm.Show();
            this.Close();
        }
    }

}
