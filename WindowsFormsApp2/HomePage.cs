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
            btFile.Visible= false;
            btQuest.Visible= false;
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
            if (!btFile.Visible)
            {
                btFile.Visible = true;
                btQuest.Visible = true;   
            }
            else
            {
                btFile.Visible = false;
                btQuest.Visible = false;
            }
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

        private void btFile_Click(object sender, EventArgs e)
        {
            
        }

        private void btQuest_Click(object sender, EventArgs e)
        {
            AddQuestion frm = new AddQuestion();
            frm.Show();
            this.Hide();
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
            /*OpenFileDialog ofd = new OpenFileDialog();
            ofd.RestoreDirectory = true;
            ofd.Title = "Browser csv file";
            ofd.DefaultExt = "csv";
            ofd.Filter = "csv files(*.csv)|*.csv";
            ofd.CheckFileExists = true;
            ofd.ShowDialog();
            StreamReader streamReader = new StreamReader(ofd.FileName.ToString());
            string table_name = Path.GetFileName(Path.GetDirectoryName(ofd.FileName));
            SqlConnection conn = GetConnection();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connect database", MessageBoxButtons.OK);
                return;
            }*/
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
        private void NumberColume(SqlConnection conn, string table)
        {
            string query = string.Format("SELECT COUNT(COLUMN_NAME) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_CATALOG = 'test' AND TABLE_SCHEMA = 'dbo'  AND TABLE_NAME = \'{0}\'", table);
            MessageBox.Show(query);
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                int num = (int)cmd.ExecuteScalar();
                MessageBox.Show(num.ToString());
            }
        }
        private void WriteValue(SqlConnection conn, string FolderPath, string query, string table)
        {
            string folderPath = FolderPath + "\\" + table;
            int count = 0;
            DateTime today = DateTime.Today;
            NumberColume(conn, table);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            StreamWriter csvFile = null;     //Wirter for csv file
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using(SqlDataReader reader = cmd.ExecuteReader())
                {           
                    string folderName = string.Format("backup{0}_{1}_{2}.csv", today.Day.ToString(), today.Month.ToString(), today.Year.ToString());
                    using (csvFile = new StreamWriter(folderPath + "\\" + folderName, false, Encoding.UTF8))
                    {
                        csvFile.WriteLine(String.Format("\"{0}\",\"{1}\",\"{2}\"," + "\"{3}\"",               //Add colume name
                        reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3)));
                        while (reader.Read())                                                                 //Array reader (value_col1, value_col2, value_col3)
                        {
                            csvFile.WriteLine(String.Format("\"{0}\",\"{1}\",\"{2}\"," + "\"{3}\"",           //Add row value
                            reader[0], reader[1], reader[2], reader[3]));
                        }
                    }
                }
            }
            return;
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
                string query = "select * from question";
                string query_TN = "select * from trac_nghiem";
                FolderBrowserDialog choofdlog = new FolderBrowserDialog();
                choofdlog.ShowDialog();
                string FolderPath = choofdlog.SelectedPath;
                WriteValue(conn, FolderPath, query, "question");
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
                conn.Close();    //Close database
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
