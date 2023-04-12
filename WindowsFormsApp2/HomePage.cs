using System;
using System.IO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Security.AccessControl;

namespace WindowsFormsApp2
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        SqlConnect sqlConnect = new SqlConnect();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            btRestore.Visible= false;
            btBackup.Visible= false;
            btQL.Visible= false;
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            Test_Generate form = new Test_Generate(this);
            form.Show();
            this.Visible = false;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            AddQuestion frm = new AddQuestion();
            frm.Show();
            this.Hide();
        }

        private void tbCancel_Click(object sender, EventArgs e)
        {
            /*DialogResult res = MessageBox.Show("Bạn có muốn thoát chương trình?", "", MessageBoxButtons.OKCancel);
            if(res == DialogResult.OK)
            {
                this.Close();
            }*/
            this.Close();
        }
        private void btControl_Click(object sender, EventArgs e)
        {
            if (!btRestore.Visible)
            {
                btRestore.Visible = true;
                btBackup.Visible = true;
                btQL.Visible = true;
            }
            else
            {
                btRestore.Visible = false;
                btBackup.Visible = false;
                btQL.Visible = false;
            }
        }

        private void btRestore_Click(object sender, EventArgs e)
        {
            ImportData frm = new ImportData();
            frm.Show();
            this.Visible = false;
        }

        private void btQL_Click(object sender, EventArgs e)
        {
            ManageQues frm = new ManageQues();
            frm.Show();
            this.Hide();
        }
        private void WriteValue(SqlConnection conn, string FolderPath, string query, string table)
        {
            DataTable dt = new DataTable();
            DateTime today = DateTime.Today;
            string folderName = string.Format("{0}backup{1}_{2}_{3}.csv", table, today.Day.ToString(), today.Month.ToString(), today.Year.ToString());
            string folderPath = FolderPath + "\\" + table;
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (SqlDataAdapter adt = new SqlDataAdapter(query, conn))
            {
                adt.Fill(dt);
            }
            using (StreamWriter sw = new StreamWriter(folderPath + "\\" + folderName, false, Encoding.UTF8))
            {
                for (int i = 0; i < dt.Columns.Count; ++i)
                {
                    if (i < dt.Columns.Count - 1)
                    {
                        sw.Write(dt.Columns[i].ColumnName + ",");
                    }
                    else
                    {
                        sw.Write(dt.Columns[i].ColumnName);
                    }
                }
                sw.Write(sw.NewLine);
                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; ++i)
                    {
                        if (!Convert.IsDBNull(row[i]))
                        {
                            string value = row[i].ToString();
                            if (value.Contains(','))
                            {
                                value = String.Format("\"{0}\"", value);
                                sw.Write(value);
                            }
                            else
                            {
                                sw.Write(value);
                            }
                        }
                        if(i < dt.Columns.Count - 1)
                        {
                            sw.Write(',');
                        }
                    }
                    sw.Write('\n');
                }
                return;
            }
        }
        private void btBackup_Click(object sender, EventArgs e)
        {
            SqlConnection conn = sqlConnect.connectSQL();
            try
            {
                conn.Open();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Connect database", MessageBoxButtons.OK);
                return;
            }
            try
            {
                string query_TN = "SELECT question.ID, question.Noi_dung, question.Hoc_phan, question.Kieu_cau_hoi, trac_nghiem.A, trac_nghiem.B, trac_nghiem.C, trac_nghiem.D, trac_nghiem.Lua_chon, trac_nghiem.Diem FROM question INNER JOIN trac_nghiem ON question.ID = trac_nghiem.ID_question";
                string query_TL = "SELECT question.ID, question.Noi_dung, question.Hoc_phan, question.Kieu_cau_hoi, tu_luan.Diem FROM question INNER JOIN tu_luan ON question.ID = tu_luan.ID_question";
                FolderBrowserDialog choofdlog = new FolderBrowserDialog();
                choofdlog.ShowDialog();
                string FolderPath = choofdlog.SelectedPath;
                WriteValue(conn, FolderPath, query_TL, "tu_luan");
                WriteValue(conn, FolderPath, query_TN, "trac_nghiem");
                MessageBox.Show("Export successful in " + FolderPath, "Backup database", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Backup database", MessageBoxButtons.OK);
                return;
            }
            finally
            {
                conn.Close();//Close database
            }
        }

    }
}
