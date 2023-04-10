using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class TestPreview : Form
    {
        DataTable dt = new DataTable();
        SqlConnect sql = new SqlConnect();
        public TestPreview(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void TestPreview_Load(object sender, EventArgs e)
        {
            dgvList.DataSource = dt;
        }
    }
}
