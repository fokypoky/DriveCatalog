using System.Data.SqlClient;

namespace DriveCatalog.Data
{
    public static class DataBase
    {
        public static SqlConnection Connection { get; set; }
        public static string ConnectionString { get; set; }

        public static void Open()
        {
            if(Connection != null && Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Close();
            }
        }
        public static void Close()
        {
            if(Connection != null && Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
        }
    }
}
