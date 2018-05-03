using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Ladu.SQL
{
    class Insert
    {
        public static int InsertNewKlient(Klient klient)
        {
            using (OleDbConnection conn = ConnectDB.GetConnection())
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO klient(Nimi, Perekonnanimi, Telefon, Aadress, Email) VALUES (?,?,?,?,?)";
                cmd.Parameters.AddWithValue("@nimi", klient.Nimi);
                cmd.Parameters.AddWithValue("@perekonnanimi", klient.Perekonnanimi);
                cmd.Parameters.AddWithValue("@telefon", klient.Telefon);
                cmd.Parameters.AddWithValue("@aadress", klient.Aadress);
                cmd.Parameters.AddWithValue("@email", klient.Email);
                cmd.Connection = conn;
                conn.Open();
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
        public static int InsertNewToode(Toode toode)
        {
            using (OleDbConnection conn = ConnectDB.GetConnection())
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO toode(Nimi, kategoriaFK, Kogus, KoodTood, Hind) VALUES (?,?,?,?,?)";
                cmd.Parameters.AddWithValue("@nimi", toode.Nimi);
                cmd.Parameters.AddWithValue("@kategoriafk", toode.KategoriaFK);
                cmd.Parameters.AddWithValue("@kogus", toode.Kogus);
                cmd.Parameters.AddWithValue("@koodtood", toode.KoodToode);
                cmd.Parameters.AddWithValue("@hind", toode.Hind);
                cmd.Connection = conn;
                conn.Open();
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
    }
}
