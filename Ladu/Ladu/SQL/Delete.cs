using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Ladu.SQL
{
    class Delete
    {
        public static int DeleteKlient(int id)
        {
            using (OleDbConnection conn = ConnectDB.GetConnection())
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("DELETE * FROM klient WHERE ID =" + id, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    return 0;
                }
            }
                return 1;
        }
        public static int DeleteToode(int id)
        {
            using (OleDbConnection conn = ConnectDB.GetConnection())
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("DELETE * FROM toode WHERE ID = " + id, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    
                }
                catch
                {
                    return 0;
                }
                return 1;
            }
        }
    }
}
