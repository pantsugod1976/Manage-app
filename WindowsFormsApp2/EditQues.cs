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
    public partial class EditQues : Form
    {
        string type;
        SqlConnect sql;
        public EditQues(string description, string subject, string point)
        {
            InitializeComponent();
            tbDescription.Text = description;
            tbSubject.Text = subject;
            tbPoint.Text = point;
            type = "tự luận";
        }
        public EditQues(string description, string subject, string point, string A, string B, string C, string D, string choice)
        {
            InitializeComponent();
            tbDescription.Text = description;
            tbSubject.Text = subject;
            tbPoint.Text = point;
            tbA.Text = A;
            tbB.Text = B;
            tbC.Text = C;
            tbD.Text = D;
            type = "Trắc nghiệm";
            switch(choice)
            {
                case "A":
                    rbA.Checked = true;
                    break;
                case "B":
                    rbB.Checked = true;
                    break;
                case "C":
                    rbC.Checked = true;
                    break;
                case "D":
                    rbD.Checked = true;
                    break;
            }
            gbChoice.Show();
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Ques_detail"].Show();
            this.Close();
        }

        private void EditQues_Load(object sender, EventArgs e)
        {
            Console.WriteLine(type);
            if(type == "tự luận")
            gbChoice.Hide();
        }
    }
}
