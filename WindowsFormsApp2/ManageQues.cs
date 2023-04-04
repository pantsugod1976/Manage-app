using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx;

namespace WindowsFormsApp2
{
    public partial class ManageQues : Form
    {
        public ManageQues()
        {
            InitializeComponent();
        }
        SqlConnect sqlConnect = new SqlConnect();

        private void ManageQues_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM question";
            using (MySqlConnection conn = sqlConnect.connectSQL())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                        }
                    }
                }
            }
        }
    }

}
