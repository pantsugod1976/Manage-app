using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SQL_Connect
{
    public class MySqlUlities
    {
        public static MySqlConnection GetDBMySqlConnect()
        {
            string host = "localhost";
            int port = 3306;
            string database = "test";
            string username = "root";
            string password = "";
            return DBMySqlUlti.GetDBMySqlConnect(host, port, database, username, password);
        }
    }
}

