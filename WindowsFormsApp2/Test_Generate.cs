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
using MySql.Data.MySqlClient;
using Mysqlx;
using SQL_Connect;

namespace WindowsFormsApp2
{
    public partial class Test_Generate : Form
    {
        public Test_Generate(HomePage frm)
        {
            InitializeComponent();
        }

        private void lb_Click(object sender, EventArgs e)
        {

        }

        private void tbCancel_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Enabled = true;
            homePage.Show();
            this.Close();
        }

        private MySqlCommand QuerySQL_TN(MySqlConnection conn)
        {
            string query_TN = "Select ID from question where Subject = \"" + tbSubject.Text + "\" && Type = 0 order by rand() limit " + numberChoice.Value;
            MySqlCommand cmd_TN = new MySqlCommand();
            cmd_TN.Connection = conn;
            cmd_TN.CommandText = query_TN;
            return cmd_TN;
        }

        private MySqlCommand QuerySQL_TL(MySqlConnection conn)
        {
            string query_TL = "Select ID from question where Subject= \"" + tbSubject.Text + "\" && Type = 1 order by rand() limit " + numberEssay.Value;
            MySqlCommand cmd_TL = new MySqlCommand();
            cmd_TL.Connection = conn;
            cmd_TL.CommandText = query_TL;
            return cmd_TL;
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = MySqlUlities.GetDBMySqlConnect();
            try
            {
                conn.Open(); 
            } 
            catch(Exception ex) 
            {
                DialogResult res = MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);
            } 
            MySqlCommand cmd_TN = QuerySQL_TN(conn);
            MySqlCommand cmd_TL = QuerySQL_TL(conn);
            MySqlCommand[] cmd = new MySqlCommand[2];
            cmd[0] = cmd_TN;
            cmd[1] = cmd_TL;
            Control_test frm = new Control_test(cmd);
            frm.Show();
        }

        private void Test_Generate_Load(object sender, EventArgs e)
        {
            
        }
    }
}
