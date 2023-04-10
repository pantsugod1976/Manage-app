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
        private void lb_Click(object sender, EventArgs e)
        {

        }

        private void tbCancel_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["HomePage"];
            frm.Show();
            this.Close();
        }

        private DataTable GetQuestion(string query)
        {
            using (SqlConnection conn = sql.connectSQL())
            {
                conn.Open();
                using (SqlDataAdapter ad = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    return dt;
                }
            }
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            string query;
            int res = (int)numericUpDown1.Value;
            query = "SELECT TOP " + res.ToString() + " ID, Noi_dung, Kieu_cau_hoi FROM (SELECT * FROM question WHERE Hoc_phan = N\'" + cbSubject.SelectedItem.ToString() + "\' AND Kieu_cau_hoi = N\'" + cbType.SelectedItem.ToString() + "\')a ORDER BY NEWID()";
            if (res > 0)
            {
                TestPreview frm = new TestPreview(GetQuestion(query));
                frm.Show();
                this.Hide();
            }
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
        private void Test_Generate_Load(object sender, EventArgs e)
        {
            CB_Subject();
            CB_Type();
        }
    }
}
