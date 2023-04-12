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
        DataTable tmp_DT = new DataTable();
        DataTable prev_table = new DataTable();
        private void GetData()
        {
            string query = "SELECT * FROM question";
            using (SqlConnection conn = sqlConnect.connectSQL())
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(table);
                }                
            }
            dataGridView.DataSource = table;
        }
        private void Generate_Table()
        {
            GetData();
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
            dataGridView.AllowUserToAddRows = false;
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
            tmp_DT = table;
            prev_table = tmp_DT;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["HomePage"].Show();
            this.Close();
        }

        private void GetData(string query)
        {
            using (SqlConnection conn = sqlConnect.connectSQL())
            {
                using (SqlDataAdapter adt = new SqlDataAdapter(query, conn))
                {
                    adt.Fill(tmp_DT);
                }
            }
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                dataGridView.DataSource = prev_table;
                dataGridView.Refresh();
                return;
            }
            string query;
            prev_table = tmp_DT;
            tmp_DT.Clear();
            if (cbSubject.SelectedItem == null && cbType.SelectedItem == null)
            {
                query = String.Format("SELECT * FROM question WHERE Noi_dung LIKE N\'%{0}%\'", tbSearch.Text);
            }
            else
            {
                if (cbSubject.SelectedItem == null)
                {
                    query = String.Format("SELECT * FROM question WHERE Noi_dung = LIKE N\'%{1}%\' AND Kieu_cau_hoi = N\'{1}\'", tbSearch.Text, cbType.SelectedItem.ToString());
                }
                else
                {
                    if (cbType.SelectedItem == null)
                    {
                        query = String.Format("SELECT * FROM question WHERE Noi_dung LIKE N\'%{0}%\' AND Hoc_phan = N\'{1}\'", tbSearch.Text, cbSubject.SelectedItem.ToString());
                    }
                    else
                    {
                        query = String.Format("SELECT * FROM question WHERE Noi_dung LIKE N\'%{1}%\' AND Kieu_cau_hoi = N\'{0}\' AND Hoc_phan = N\'{2}\'", cbType.SelectedItem.ToString(), tbSearch.Text, cbSubject.SelectedItem.ToString());
                    }

                }
            }
            GetData(query);
            dataGridView.DataSource = tmp_DT;
            dataGridView.Refresh();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteRecord(string id, string type)
        {
            int ID = Int32.Parse(id);
            using (SqlConnection conn = sqlConnect.connectSQL())
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    if (type.Equals("tự luận", StringComparison.OrdinalIgnoreCase))
                    {
                        cmd.CommandText = "BEGIN TRANSACTION;\n" +
                            "DELETE FROM question WHERE question.ID = @ID\n\n" +
                            "DBCC CHECKIDENT(question, reseed, @prev_ID)\n\n" +
                            "DBCC CHECKIDENT(tu_luan, reseed, @prev_ID)\n\n" +
                            "COMMIT;";
                    }
                    else
                    {
                        cmd.CommandText = "BEGIN TRANSACTION;\n" +
                            "DELETE FROM question WHERE question.ID = @ID;\n\n" +
                            "DBCC CHECKIDENT(question, reseed, @prev_ID)\n\n" +
                            "DBCC CHECKIDENT(trac_nghiem, reseed, @prev_ID)\n\n" +
                            "COMMIT;";
                    }
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@prev_ID", ID-1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "", MessageBoxButtons.OK);
                }
            }
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)   //header column
            {
                return;
            }
            string id = dataGridView.Rows[e.RowIndex].Cells[dataGridView.Columns["ID"].Index].Value.ToString();
            string type = dataGridView.Rows[e.RowIndex].Cells[dataGridView.Columns["Kieu_cau_hoi"].Index].Value.ToString();
            if (e.ColumnIndex == dataGridView.Columns["Chi tiet"].Index) 
            {
                
                Ques_detail frm = new Ques_detail(id, type);
                frm.Show();
                this.Hide();
            }
            if (e.ColumnIndex == dataGridView.Columns["Xoa"].Index)
            {
                DeleteRecord(id, type);
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedItem == null)
            {
                dataGridView.DataSource = prev_table;
                dataGridView.Refresh();
                return;
            }
            string query;
            prev_table = tmp_DT;
            tmp_DT.Clear();
            if(cbSubject.SelectedItem == null && tbSearch.Text == "")
            {
                query = String.Format("SELECT * FROM question WHERE Kieu_cau_hoi = N\'{0}\'", cbType.SelectedItem.ToString());
            }
            else
            {
                if (cbSubject.SelectedItem == null)
                {
                    query = String.Format("SELECT * FROM question WHERE Noi_dung = LIKE N\'%{1}%\' AND Kieu_cau_hoi = N\'{1}\'", tbSearch.Text, cbType.SelectedItem.ToString());
                }
                else
                {
                    if (tbSearch.Text == "")
                    {
                        query = String.Format("SELECT * FROM question WHERE Kieu_cau_hoi = N\'{0}\' AND Hoc_phan = N\'{1}\'", cbType.SelectedItem.ToString(), cbSubject.SelectedItem.ToString());
                    }
                    else
                    {
                        query = String.Format("SELECT * FROM question WHERE Noi_dung LIKE N\'%{1}%\' AND Kieu_cau_hoi = N\'{0}\' AND Hoc_phan = N\'{2}\'", cbType.SelectedItem.ToString(), tbSearch.Text, cbSubject.SelectedItem.ToString());
                    }

                }
            }
            GetData(query);
            dataGridView.DataSource = tmp_DT;
            dataGridView.Refresh();
        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string query;
            prev_table = tmp_DT;
            tmp_DT.Clear();
            if (cbType.SelectedItem == null && tbSearch.Text == "")
            {
                query = String.Format("SELECT * FROM question WHERE Hoc_phan = N\'{0}\'", cbType.SelectedItem.ToString());
            }
            else
            {
                if (cbType.SelectedItem == null)
                {
                    query = String.Format("SELECT * FROM question WHERE Noi_dung = LIKE N\'%{1}%\' AND Hoc_phan = N\'{1}\'", tbSearch.Text, cbSubject.SelectedItem.ToString());
                }
                else
                {
                    if (tbSearch.Text == "")
                    {
                        query = String.Format("SELECT * FROM question WHERE Kieu_cau_hoi = N\'{0}\' AND Hoc_phan = N\'{1}\'", cbType.SelectedItem.ToString(), cbSubject.SelectedItem.ToString());
                    }
                    else
                    {
                        query = String.Format("SELECT * FROM question WHERE Noi_dung LIKE N\'%{1}%\' AND Kieu_cau_hoi = N\'{0}\' AND Hoc_phan = N\'{2}\'", cbType.SelectedItem.ToString(), tbSearch.Text, cbSubject.SelectedItem.ToString());
                    }
                }  
            }
            GetData(query);
            dataGridView.DataSource = tmp_DT;
            dataGridView.Refresh();
        }

        private void cbType_TextChanged(object sender, EventArgs e)
        {
            if (cbSubject.SelectedText == "")
            {
                dataGridView.DataSource = prev_table;
                dataGridView.Refresh();
                return;
            }
        }
    }
}
