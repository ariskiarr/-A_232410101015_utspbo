using A_1015_Ariski_Ade_Rahajro.App.model;
using core;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_1015_Ariski_Ade_Rahajro.App.context
{
    internal class C_TambahKontak : DatabaseWrapper
    {
        private static string table = "kontak";

        public static DataTable All()
        {
            string query = @"
            SELECT *
            FROM kontak";


            DataTable datamahasiswa = queryExecutor(query);
            return datamahasiswa;
        }

        public static void addkontak(Kontak kontakbaru)
        {
            string query = $"INSERT INTO {table} (nama, email,no_hp) VALUES(@nama, @email,@no_hp);";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama", kontakbaru.nama),
                new NpgsqlParameter("@email", kontakbaru.email),
                new NpgsqlParameter("@no_hp", kontakbaru.no_hp),
            };
            commandExecutor(query, parameters);
        }
    }
}
