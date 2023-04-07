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
            Form frm = Application.OpenForms["HomePage"];
            frm.Show();
            this.Close();
        }

        private SqlCommand QuerySQL_TN(SqlConnection conn)
        {
            string query_TN = "Select ID from question where Subject = \"" + tbSubject.Text + "\" && Type = 0 order by rand() limit " + numberChoice.Value;
            SqlCommand cmd_TN = new SqlCommand();
            cmd_TN.Connection = conn;
            cmd_TN.CommandText = query_TN;
            return cmd_TN;
        }

        private SqlCommand QuerySQL_TL(SqlConnection conn)
        {
            string query_TL = "Select ID from question where Subject= \"" + tbSubject.Text + "\" && Type = 1 order by rand() limit " + numberEssay.Value;
            SqlCommand cmd_TL = new SqlCommand();
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
