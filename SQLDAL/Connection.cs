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
            string connstring = "Data Source=DESKTOP-RJRT34C\\TURINGWEISQL;Initial Catalog=wdjnote;Integrated Security=True";// System.Configuration.ConfigurationManager.AppSettings["connString"];
            return connstring;
        }
    }
}
