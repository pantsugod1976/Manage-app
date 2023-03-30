using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
        public MySqlConnection GetConnection()
        {
            SqlConnect conn = new SqlConnect();
            return conn.connectSQL();
        }
        private void ImportData_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE  TABLE_TYPE = 'BASE TABLE' AND TABLE_SCHEMA = 'test'", conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        cbTable.Items.Clear();
                        while (reader.Read())
                        {
                            cbTable.Items.Add((string)reader["TABLE_NAME"]);
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.RestoreDirectory = true;
            ofd.Title = "Browser csv file";
            ofd.DefaultExt = "csv";
            ofd.Filter = "csv files(*.csv)|*.csv";
            ofd.CheckFileExists = true;
            ofd.ShowDialog();
            StreamReader streamReader = new StreamReader(ofd.FileName.ToString());
            string table_name = Path.GetFileName(Path.GetDirectoryName(ofd.FileName));
            tbFile.Text = Path.GetDirectoryName(ofd.FileName);
            MySqlConnection conn = GetConnection();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connect database", MessageBoxButtons.OK);
                return;
            }

        }
    }
}
