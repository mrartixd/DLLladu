using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Ladu
{
    class ConnectDB
    {
        public static String connectionString;
        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(connectionString);
        }
    }
}
