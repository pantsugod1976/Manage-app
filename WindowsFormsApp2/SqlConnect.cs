using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx;

namespace WindowsFormsApp2
{
    internal class SqlConnect
    {
        public MySqlConnection connectSQL()
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=test;");
            return conn;
        }
    }
}
