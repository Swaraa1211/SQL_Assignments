using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLProject
{
    internal class Connection
    {
        public static string ConnString= "Data Source=5CG7324TYL;Initial Catalog = LMS_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public static SqlConnection connection = new SqlConnection(ConnString);
    }
}
