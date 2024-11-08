using core;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace A_1015_Ariski_Ade_Rahajro.App.context
{
    internal class C_Login : DatabaseWrapper
    {
        private string table = "akun_user";

        public static DataTable Cek()
        {
            string query = @"
            SELECT 
            COUNT(*) FROM akun_user WHERE username = @username AND password = @password";

            DataTable _akunuser = queryExecutor(query);
            return _akunuser;

        }


    }
}


