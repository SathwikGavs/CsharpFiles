using Microsoft.Data.SqlClient;

namespace FirstMvcApp.Models
{
    public class SqlHelper
    {
        public static SqlConnection CreateConnection()
        {
            var connString = @"server=200411LTP2811\SQLEXPRESS; database=sqltestdb; integrated security=true;Encrypt=false;";
            SqlConnection sqlcn = new SqlConnection(connString);
            return sqlcn;
        }

    }
}
