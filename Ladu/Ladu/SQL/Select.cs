﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Ladu
{
    class Select
    {
        public static List<Klient> GetKlients()
        {
            List<Klient> klients = null;
            using (OleDbConnection conn = ConnectDB.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM klient";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                klients = new List<Klient>();
                using (reader)
                {
                    while (reader.Read())
                    {
                        Klient klient = new Klient();
                        klient.ID = (long)reader[0];
                        klient.Nimi = reader[1].ToString();
                        klient.Perekonnanimi = reader[2].ToString();
                        klient.Telefon = reader[3].ToString();
                        klient.Aadress = reader[4].ToString();
                        klient.Email = reader[5].ToString();
                    }
                }
            }
            return klients;
        }

        public static List<Toode> GetToodes()
        {
            List<Toode> toodes = null;
            using (OleDbConnection conn = ConnectDB.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM toode";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                OleDbCommand cmdKategoria = new OleDbCommand("SELECT * FROM Alamkategooria");
                OleDbDataReader reader = cmd.ExecuteReader();
                //
                toodes = new List<Toode>();
                using (reader)
                {
                    while (reader.Read())
                    {
                        Toode toode = new Toode();
                        toode.ID = (long)reader[0];
                        toode.Nimi = reader[1].ToString();
                        //
                    }
                }
            }
                return toodes;
        }
    }
}
