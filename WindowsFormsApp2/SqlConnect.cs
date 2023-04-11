using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    internal class SqlConnect
    {
        public SqlConnection connectSQL()
        {
            string servername = "LAPTOP-U8NL2OBT\\SQLEXPRESS";
            string database = "test";
            string connect_string = String.Format("server = {0}; database = {1}; integrated security = true", servername, database);
            SqlConnection conn = new SqlConnection(connect_string);
            return conn;
        }
    }
}
