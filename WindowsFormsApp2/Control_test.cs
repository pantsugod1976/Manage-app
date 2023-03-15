using System;
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
using SQL_Connect;

namespace WindowsFormsApp2
{
    public partial class Control_test : Form
    {
        private MySqlCommand cmd_TN, cmd_TL;
        public Control_test(MySqlCommand[] cmd)
        {
            cmd_TN = cmd[0];
            cmd_TL = cmd[1];
            InitializeComponent();
        }
        private void CreateTiltle(string t)
        {
            Label lbTiltle = new Label();
            lbTiltle.Location = new System.Drawing.Point(12, 12);
            lbTiltle.Size = new Size(123, 29);
            lbTiltle.Text = t;
            Font oldFont = lbTiltle.Font;
            lbTiltle.Font = new Font(oldFont.FontFamily, 12f, FontStyle.Bold);
            this.Controls.Add(lbTiltle);
        }
        private Label CreateLabel(string lbName, int Location_x, int Location_y, int size_x, int size_y)
        {
            Label temp = new Label();
            temp.Name = lbName;
            temp.Location = new System.Drawing.Point(Location_x, Location_y);
            temp.Size = new Size(size_x, size_y);
            return temp;
        }
        private void QuestionConcept(MySqlDataReader reader)
        {
            List<Label> labels= new List<Label>();
            labels[0] = CreateLabel("lbQuestion", 12, 47, 776, 53);
            labels[1] = CreateLabel("lb_choiceA", 12, 116, 776, 38);
            labels[2] = CreateLabel("lb_choiceB", 12, 163, 776, 38);
            labels[3] = CreateLabel("lb_choiceC", 12, 212, 776, 38);
            labels[4] = CreateLabel("lb_choiceD", 12, 262, 776, 38);
        }
        private void getData(MySqlCommand cmd, string t)
        {
            CreateTiltle(t);
            using(MySqlDataReader reader = cmd.ExecuteReader())
            {
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        QuestionConcept(reader);
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Control_test_Load(object sender, EventArgs e)
        {
            getData(cmd_TN, "Trắc nghiệm");
        }
    }
}
