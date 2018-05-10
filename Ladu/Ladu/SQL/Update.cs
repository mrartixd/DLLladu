using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Ladu.SQL
{
    class Update
    {
        public static int UpdateKlient(Klient klient, long id)
        {
            using (OleDbConnection conn = ConnectDB.GetConnection())
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE klient SET Nimi = @nimi, Perekonnanimi = @perekonnanimi, " + "Telefon = @telefon, Aadress = @aadress, Email = @email WHERE ID = @id";
                cmd.Parameters.AddWithValue("@nimi", klient.Nimi);
                cmd.Parameters.AddWithValue("@perekonnanimi", klient.Perekonnanimi);
                cmd.Parameters.AddWithValue("@telefon", klient.Telefon);
                cmd.Parameters.AddWithValue("@aadress", klient.Aadress);
                cmd.Parameters.AddWithValue("@email", klient.Email);
                cmd.Parameters.AddWithValue("@id", id);
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
        public static int UpdateToode(Toode toode, Klient id)
        {
            using (OleDbConnection conn = ConnectDB.GetConnection())
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE toode SET Nimi = @nimi, kategooriaFK = @kategooriaFK, Kogus = @kogus, KoodToode = @koodtoode, Hind = @hind WHERE ID = @id";
                cmd.Parameters.AddWithValue("@nimi", toode.Nimi);
                cmd.Parameters.AddWithValue("@kategooriaFK", toode.KategoriaFK);
                cmd.Parameters.AddWithValue("@kogus", toode.Kogus);
                cmd.Parameters.AddWithValue("@koodtoode", toode.KoodToode);
                cmd.Parameters.AddWithValue("@hind", toode.Hind);
                cmd.Parameters.AddWithValue("@id", id);
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
