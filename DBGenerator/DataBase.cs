using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace DBGenerator
{
    class DataBase
    {
        private static String pathCSV = @"J:\DB\CDB\";
        private static String path = @"J:\DB\KGBD.mdf";


        SqlConnection sqlConnection = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+path+";Integrated Security=True;Connect Timeout=30");

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

        public string getPath()
        {
            return path;
        }

        public string getCSVPath()
        {
            return pathCSV;
        }
    }
}
