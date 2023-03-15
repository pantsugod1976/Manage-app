using System;

using namespace SQL_Connect
{
    public class MySqlUlities
    {
        public static DBMySqlConnect GetDBMySqlConnect()
        {
            string host = "localhost";
            int port = 3306;
            string database = "test";
            string username = "root";
            string password = "";
            return GetDBMySqlConnect(host, port, database, username, password);
        }
    }
}

