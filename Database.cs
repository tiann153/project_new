using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace ProjectOne.Data
{
    public static class Database
    {
        private const string MySqlConnectionString = "Server=localhost;Database=app_database_new;Uid=root;Pwd=123456789";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(MySqlConnectionString);
        }
    }
}
