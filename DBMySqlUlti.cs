using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using namespace SQL_Connect
{
    public class DBMySqlUlti
    {
        public static DBMySqlConnect
            GetDBMySqlConnect(string host, int port, string database, string username, string password)
        {
            String connString = "Server=" + host + ";Database=" + database
                    + ";port=" + port + ";User Id=" + username + ";password=" + password;

            DBMySqlConnect conn = new DBMySqlConnect(connString);

            return conn;
        }
    }
}


