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
            homePage.Visible = true;
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
            
        }

        private void Test_Generate_Load(object sender, EventArgs e)
        {
            
        }
    }
}
