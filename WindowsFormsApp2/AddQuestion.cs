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
    public partial class AddQuestion : Form
    {
        public AddQuestion()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void AddQuestion_Load(object sender, EventArgs e)
        {
            gbChoice.Hide();
        }

        private void gbType_Enter(object sender, EventArgs e)
        {

        }

        private void rbChoice_CheckedChanged(object sender, EventArgs e)
        {
            if(rbChoice.Checked)
            {
                gbChoice.Enabled = true;
            }
        }
    }
}
