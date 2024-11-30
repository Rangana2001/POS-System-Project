using System;
using System.Data.SqlClient;

namespace SmartBillPosSystem
{
    internal class MainClass
    {
        public static SqlConnection GetSqlConnection()
        {

            string connectionString = "Data Source=DESKTOP-C95BV0J\\SQLEXPRESS; Initial Catalog=smartbill; Integrated Security=True; Encrypt=True; TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
