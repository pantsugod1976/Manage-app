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
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class ManageQues : Form
    {
        public ManageQues()
        {
            InitializeComponent();
        }
        SqlConnect sqlConnect = new SqlConnect();
        DataTable table = new DataTable();
        private void Generate_Table()
        {
            string query = "SELECT * FROM question";          
            using (SqlConnection conn = sqlConnect.connectSQL())
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
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
            col_delete.UseColumnTextForButtonValue = true;
            col_delete.Text = "Delete";
            col_delete.Name = "Xoa";
            dataGridView.Columns.Add(col_delete);
        }
        private void CB_Subject()
        {
            string query = "SELECT DISTINCT Hoc_phan FROM question";
            using (SqlConnection conn = sqlConnect.connectSQL())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                   using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbSubject.Items.Add(reader["Hoc_phan"].ToString());
                        }
                    }
                }                
            }
        }
        private void CB_Type()
        {
            string query = "SELECT DISTINCT Kieu_cau_hoi FROM question";
            using (SqlConnection conn = sqlConnect.connectSQL())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbType.Items.Add(reader["Kieu_cau_hoi"].ToString());
                        }
                    }
                }
            }
        }
        private void ManageQues_Load(object sender, EventArgs e)
        {
            Generate_Table();
            CB_Subject();
            CB_Type();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["HomePage"].Show();
            this.Close();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DeleteRecord(int i)
        {

        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            if(e.RowIndex < 0)   //header column
            {
                return;
            }
            if(e.ColumnIndex == dataGridView.Columns["Chi tiet"].Index) 
            {
                string id = dataGridView.Rows[e.RowIndex].Cells[dataGridView.Columns["ID"].Index].Value.ToString();
                string type = dataGridView.Rows[e.RowIndex].Cells[dataGridView.Columns["Kieu_cau_hoi"].Index].Value.ToString();
                Ques_detail frm = new Ques_detail(id, type);
                frm.Show();
                this.Hide();
            }
            if (e.ColumnIndex == dataGridView.Columns["Xoa"].Index)
            {
                DeleteRecord(e.RowIndex);
            }
        }
    }

}
