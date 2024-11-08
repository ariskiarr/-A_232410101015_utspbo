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
    internal class C_Register : DatabaseWrapper
    {
        private string table = "akun_user";

        public static DataTable All()
        {
            string query = @"
            SELECT *
            FROM akun_user";

         
            DataTable datamahasiswa = queryExecutor(query);


            return datamahasiswa;
        }
        public static void addAkunUser(Akun_user akunUser)
        {
            string query = $"INSERT INTO akun_user (username, password) VALUES(@username, @password);";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", akunUser.username),
                new NpgsqlParameter("@password", akunUser.password),
            };
            commandExecutor(query, parameters);
        }
    }

}
