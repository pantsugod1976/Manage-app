using MySql.Data.MySqlClient;
using Mysqlx;
using SQL_Connect;
using System;
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

namespace WindowsFormsApp2
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Enable_btGenerate()
        {
            btTest.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btFile.Visible= false;
            btQuest.Visible= false;
            btRestore.Visible= false;
        }

        public Button BtnTest
        {
            get { return btTest; }
            set { btTest = value; }
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            Test_Generate form = new Test_Generate(this);
            form.Show();
            btTest.Enabled=false;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (!btFile.Visible)
            {
                btFile.Visible = true;
                btQuest.Visible = true;
                btRestore.Visible = true;
            }
            else
            {
                btFile.Visible = false;
                btQuest.Visible = false;
                btRestore.Visible = false;
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
        }
    }
}
