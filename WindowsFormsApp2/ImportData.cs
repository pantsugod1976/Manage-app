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
        DataTable table = new DataTable();
        private void ImportData_Load(object sender, EventArgs e)
        {
            cbType.Items.Add("Trắc nghiệm");
            cbType.Items.Add("Tự luận");
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["HomePage"];
            frm.Show();
            this.Close();
        }

        private void btRestore_Click(object sender, EventArgs e)
        {
            ImportSql(table);
            MessageBox.Show("Restore successful", "", MessageBoxButtons.OK);
        }
        private DataTable GetCsvData(string filePath)
        {
            DataTable dt = new DataTable();
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string[] headers = reader.ReadLine().Split(','); //Chia cac gia tri theo dau ','
                    foreach(string header in headers)
                    {
                        dt.Columns.Add(header);
                    }
                    while (!reader.EndOfStream)
                    {
                        string[] rows = reader.ReadLine().Split(',');
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < headers.Length; i++) //Chia khoang gia tri theo cot
                        {
                            dr[i] = rows[i];
                        }
                        dt.Rows.Add(dr);
                    }
                }
            return dt;
        }
        private void ImportSql(DataTable dt)
        {
           using (SqlConnection conn = sql.connectSQL())
           {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from question where Kieu_cau_hoi = @type";
                    cmd.Parameters.AddWithValue("@type", cbType.SelectedText);
                    cmd.ExecuteNonQuery();
                    if(cbType.SelectedText.Equals("trắc nghiệm", StringComparison.OrdinalIgnoreCase))
                    {
                        cmd.CommandText =
                            "BEGIN TRANSACTION;\n\n" +
                            "DECLARE @output AS TABLE (Question_ID INT)\n" + //Tao bang output vs cot Question_ID
                            "INSERT INTO question (Noi_dung, Hoc_phan, Kieu_cau_hoi)\nOUTPUT inserted.ID INTO @output(Question_ID)\nVALUES (@description, @subject, @type)\n\n" +
                            "DECLARE @Question_ID INT\n SELECT @Question_ID = Question_ID FROM @output\n\n" +
                            "INSERT INTO trac_nghiem(ID_question, A, B, C, D, Lua_chon, Diem) VALUES (@Question_ID, @A, @B, @C, @D, @answer, @point)\n" +
                            "COMMIT;"
                            ;
                        foreach(DataRow r in dt.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@description", r["Noi_dung"].ToString());
                            cmd.Parameters.AddWithValue("@subject", r["Hoc_phan"].ToString());
                            cmd.Parameters.AddWithValue("@type", cbType.SelectedText);
                            cmd.Parameters.AddWithValue("@A", r["A"].ToString());
                            cmd.Parameters.AddWithValue("@B", r["B"].ToString());
                            cmd.Parameters.AddWithValue("@C", r["C"].ToString());
                            cmd.Parameters.AddWithValue("@D", r["D"].ToString());
                            cmd.Parameters.AddWithValue("@answer", r["Lua_chon"].ToString());
                            cmd.Parameters.AddWithValue("@point", r["Diem"].ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        cmd.CommandText =
                            "BEGIN TRANSACTION;\n\n" +
                            "DECLARE @output AS TABLE (Question_ID INT)\n" + //Tao bang output vs cot Question_ID
                            "INSERT INTO question (Noi_dung, Hoc_phan, Kieu_cau_hoi)\n OUTPUT inserted.ID INTO @output(Question_ID)\n VALUES (@description, @subject, @type)\n\n" +
                            "DECLARE @Question_ID INT\n SELECT @Question_ID = Question_ID FROM @output\n\n" +
                            "INSERT INTO tu_luan(ID_question, Diem) VALUES (@Question_ID, @point)\n" +
                            "COMMIT;"
                           ;
                        foreach (DataRow r in dt.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@type", cbType.SelectedText);
                            cmd.Parameters.AddWithValue("@description", r["Noi_dung"].ToString());
                            cmd.Parameters.AddWithValue("@subject", r["Hoc_phan"].ToString());
                            cmd.Parameters.AddWithValue("@point", r["Diem"].ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
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
            if (cbType.SelectedText.Equals("Trắc nghiệm", StringComparison.OrdinalIgnoreCase))
            {
                if (Path.GetFileNameWithoutExtension(ofd.FileName).Contains("trac_nghiem*"))
                {
                    MessageBox.Show("Sai file cho cau hoi " + cbType.SelectedText);
                    return;
                }
            }
            else
            {
                if (Path.GetFileNameWithoutExtension(ofd.FileName).Contains("tu_luan*"))
                {
                    MessageBox.Show("Sai file cho cau hoi " + cbType.SelectedText);
                    return;
                }
            }
            tbFile.Text = ofd.FileName;
            table = GetCsvData(ofd.FileName);
        }
    }
}
