using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class ImportData : Form
    {
        public ImportData()
        {
            InitializeComponent();
        }
        SqlConnect sql = new SqlConnect();
        private void ImportData_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = sql.connectSQL())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT Kieu_cau_hoi FROM question", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cbType.Items.Clear();
                        while (reader.Read())
                        {
                            cbType.Items.Add(reader["Kieu_cau_hoi"].ToString());
                        }
                    }
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["HomePage"];
            frm.Show();
            this.Close();
        }

        private void btRestore_Click(object sender, EventArgs e)
        {

        }
        private DataTable GetCsvData(string filePath)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = sql.connectSQL())
            {
                using (StreamReader  reader = new StreamReader(filePath))
                {
                    string[] headers = reader.ReadLine().Split(',');
                    foreach(string header in headers)
                    {
                        dt.Columns.Add(header);
                    }
                    while (!reader.EndOfStream)
                    {
                        string[] rows = reader.ReadLine().Split(',');
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dr[i] = rows[i].Trim();
                        }
                        dt.Rows.Add(dr);
                    }
                }
            }
            return dt;
        }
        private void ImportSql(DataTable dt)
        {
            using (SqlConnection conn = sql.connectSQL())
            {
                using ()
                {

                }
            }
        }
        private void btFile_Click(object sender, EventArgs e)
        {
            if(cbType.SelectedItem == null)
            {
                MessageBox.Show("Null type", "", MessageBoxButtons.OK);
                cbType.Focus();
                return;
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.RestoreDirectory = true;
            ofd.Title = "Browser csv file";
            ofd.DefaultExt = "csv";
            ofd.Filter = "csv files(*.csv)|*.csv";
            ofd.CheckFileExists = true;
            ofd.ShowDialog();
            if (cbType.SelectedItem.ToString().Equals("Trắc nghiệm", StringComparison.OrdinalIgnoreCase))
            {
                if (Path.GetFileNameWithoutExtension(ofd.FileName).Contains("trac_nghiem*"))
                {
                    MessageBox.Show("Sai file cho cau hoi " + cbType.SelectedItem.ToString());
                    return;
                }
            }
            else
            {
                if (Path.GetFileNameWithoutExtension(ofd.FileName).Contains("tu_luan*"))
                {
                    MessageBox.Show("Sai file cho cau hoi " + cbType.SelectedItem.ToString());
                    return;
                }
            }
            tbFile.Text = ofd.FileName;
            DataTable dt = GetCsvData(ofd.FileName);
            ImportSql(dt);
        }
    }
}
