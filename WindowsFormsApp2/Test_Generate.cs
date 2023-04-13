using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace WindowsFormsApp2
{
    public partial class Test_Generate : Form
    {
        public Test_Generate(HomePage frm)
        {
            InitializeComponent();
        }
        SqlConnect sql = new SqlConnect();
        List<string> list = new List<string>();
        DataTable dt = new DataTable();
        private void tbCancel_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["HomePage"];
            frm.Show();
            this.Close();
        }
        private void CB_Subject()
        {
            string query = "SELECT DISTINCT Hoc_phan FROM question";
            using (SqlConnection conn = sql.connectSQL())
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
            using (SqlConnection conn = sql.connectSQL())
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
        private void GetQuestion()
        {
            string query = "SELECT * FROM question WHERE Hoc_phan = N\'" + cbSubject.Text + "\' AND Kieu_cau_hoi = N\'" + cbType.Text + "\'";
            using (SqlConnection conn = sql.connectSQL())
            {
                conn.Open();
                using (SqlDataAdapter ad = new SqlDataAdapter(query, conn))
                {
                    dt.Clear();
                    ad.Fill(dt);
                }
            }
            dgvList.DataSource = dt;
        }
        private void btGenerate_Click(object sender, EventArgs e)
        {
            if (cbSubject.SelectedItem == null || cbType.SelectedItem == null)
            {
                MessageBox.Show("Null value", "", MessageBoxButtons.OK);
                return;
            }
            GetQuestion();
            if (!dgvList.Columns.Contains("Check"))
            {
                DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
                dataGridViewCheckBoxColumn.ValueType = typeof(bool);
                dataGridViewCheckBoxColumn.Name = "Check";
                dataGridViewCheckBoxColumn.HeaderText = "Add";
                dgvList.Columns.Add(dataGridViewCheckBoxColumn);
            }
        }

        private void Test_Generate_Load(object sender, EventArgs e)
        {
            CB_Subject();
            CB_Type();
            dgvList.AllowUserToAddRows = false;
        }

        private void btPreview_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == dgvList.Columns["Check"].Index)
            {
                if(Convert.ToBoolean(dgvList.Rows[e.RowIndex].Cells["Check"].EditedFormattedValue))
                list.Add(dgvList.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                else
                {
                    list.Remove(dgvList.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                }
            }
        }
        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (tbSearch.Text == null)
                {
                    return;
                }
                int Row_Search = -1;
                DataGridViewRow row = dgvList.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["Noi_dung"].Value.ToString().Equals(tbSearch.Text)).First();
                Row_Search = row.Index;
                if(Row_Search == -1)
                {
                    MessageBox.Show("Không có kết quả phù hợp", "", MessageBoxButtons.OK);
                    tbSearch.Focus();
                }
                else
                {
                    dgvList.ClearSelection();
                    dgvList.Rows[Row_Search].Selected = true;
                }
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                dgvList.ClearSelection();
            }
        }
    }
}
