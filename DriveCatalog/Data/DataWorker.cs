using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace DriveCatalog.Data
{
    public static class DataWorker
    {
        public static string Execute(string querry)
        {
            using(var connection = new SqlConnection(DataBase.ConnectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(querry, connection);
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    return "Executed";
                }
                catch(Exception exceptiom)
                {
                    return exceptiom.Message;
                }
            }
        }
        public static string GetValue(string querry)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand sqlCommand = new SqlCommand(querry, DataBase.Connection);

            adapter.SelectCommand = sqlCommand;
            adapter.Fill(table);

            return table.Rows[0][0].ToString();
        }
    }
}
