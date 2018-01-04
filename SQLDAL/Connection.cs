using System.Data.SqlClient;

namespace SQLDAL
{
    class Connection
    {
        public static SqlConnection GetConn()
        {
            return new SqlConnection(GetConnString());
        }

        static string GetConnString()
        {
            return System.Configuration.ConfigurationManager.AppSettings["connString"];
        }
    }
}
