using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseConnection
{
    public class myConnections
    {
        public static SqlConnection GetConnections()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-C8URA7L\SQLEXPRESS;Initial Catalog=LibararyManagementSystem;Integrated Security=True");
            return connection;

        }
    }
}
