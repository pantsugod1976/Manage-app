﻿using MySql.Data.MySqlClient;
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
    public partial class Ques_detail : Form
    {
        int ID;
        string type;
        SqlConnect sql = new SqlConnect();
        public Ques_detail(string id, string t)
        {
            InitializeComponent();
            Int32.TryParse(id, out ID);
            type = t;
            if (type.Equals(rbChoice.Text))
            {
                rbChoice.Checked = true;
            }
            else
            {
                rbEssay.Checked = true;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["ManageQues"].Show();
        }

        private void getDetail()
        {
            string query;
            if (type.Equals("Trac nghiem"))
            {
                query = "SELECT test.Noi_dung, test.Hoc_phan, test.Kieu_cau_hoi, " +
                    "trac_nghiem.A, trac_nghiem.B, trac_nghiem.C, trac_nghiem.D, trac_nghiem.Lua_chon, trac_nghiem.Diem" +
                    "FROM question INNER JOIN trac_nghiem " +
                    "ON trac_nghiem.ID = question.ID WHERE trac_nghiem.ID = " + ID
                   ;
            }
            else
            {
                query = "SELECT test.Noi_dung, test.Hoc_phan, test.Kieu_cau_hoi, " +
                   "tu_luan.Diem" +
                   "FROM question LEFT JOIN tu_luan" +
                   " ON question.ID = tu_luan.ID" //WHERE tu_luan.ID = " + ID
                  ;
            }
            using (MySqlConnection conn = sql.connectSQL())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        tbDescription.Text = reader["Noi_dung"].ToString();
                        tbSubject.Text = reader["Hoc_phan"].ToString();
                        tbPoint.Text = reader["Diem"].ToString();
                        if (rbChoice.Checked)
                        {
                            tbA.Text = reader["A"].ToString();
                            tbB.Text = reader["B"].ToString();
                            tbC.Text = reader["C"].ToString();
                            tbD.Text = reader["D"].ToString();
                            switch (reader["Lua_chon"].ToString())
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
                        }
                    }
                }
            }
        }
        private void Ques_detail_Load(object sender, EventArgs e)
        {
            getDetail();
        }
    }
}
