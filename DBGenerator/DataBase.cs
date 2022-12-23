using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBGenerator
{
    class DataBase
    {
        SqlConnection sqlConnection = new("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=J:\\DB\\KGBD.mdf;Integrated Security=True;Connect Timeout=30");

        public void openConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
