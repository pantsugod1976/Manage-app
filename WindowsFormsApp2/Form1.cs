using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Security.AccessControl;

namespace WindowsFormsApp2
{
    public partial class HomePage : Form
    {
        public DataTable dt = new DataTable();
        public HomePage()
        {
            InitializeComponent();
        }

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
            DialogResult res = MessageBox.Show("Bạn có muốn thoát chương trình?", "", MessageBoxButtons.OKCancel);
            if(res == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            
        }

        private void btQuest_Click(object sender, EventArgs e)
        {
            AddQuestion frm = new AddQuestion();
            frm.Show();
            this.Visible = false;
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
            
        }

        private void btQL_Click(object sender, EventArgs e)
        {
            ManageQues frm = new ManageQues();
            frm.Show();
            this.Visible = false;
        }
        private void WriteValue(MySqlConnection conn, string query, string table)
        {
            FolderBrowserDialog choofdlog = new FolderBrowserDialog();
            string FolderPath = "";
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                FolderPath = choofdlog.SelectedPath;
            }
            string folderPath = FolderPath + "\\" + table;
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            StreamWriter csvFile = null;     //Wirter for csv file
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            csvFile = new StreamWriter(folderPath + "\\backup.csv", false, Encoding.UTF8); //Write to file ~ open file
            csvFile.WriteLine(String.Format("\"{0}\",\"{1}\",\"{2}\"," + "\"{3}\"",               //Add colume name
            reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3)));
            while (reader.Read()) //Array reader (value_col1, value_col2, value_col3)
            {
                csvFile.WriteLine(String.Format("\"{0}\",\"{1}\",\"{2}\"," + "\"{3}\"",               //Add row value
                reader[0], reader[1], reader[2], reader[3]));
            }
            MessageBox.Show("Export successful", "Backup database", MessageBoxButtons.OK);
            csvFile.Flush();
            csvFile.Close();
            reader.Close();
        }
        private void btBackup_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=test;");
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
                WriteValue(conn, query, "question");
                WriteValue(conn, query_TN, "trac_nghiem");
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
