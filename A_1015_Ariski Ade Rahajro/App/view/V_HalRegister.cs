using A_1015_Ariski_Ade_Rahajro.App.context;
using A_1015_Ariski_Ade_Rahajro.App.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_1015_Ariski_Ade_Rahajro.App.view
{
    public partial class V_HalRegister : Form
    {
        public V_HalRegister()
        {
            InitializeComponent();
        }
        public bool Validasiinput()
        {
            if (string.IsNullOrWhiteSpace(tbusernameregister.Text) ||
                string.IsNullOrWhiteSpace(tbpasswordregister.Text))
            {
                return false;
            }
            return true;
        }
        private void bttregister_Click(object sender, EventArgs e)
        {
            if (!Validasiinput())
            {
                MessageBox.Show("Inputan tidak valid");
                return;
            }

            Akun_user _akun_user = new Akun_user();
            {
                _akun_user.username = tbusernameregister.Text;
                _akun_user.password = tbpasswordregister.Text;


                C_Register.addAkunUser(_akun_user);
                MessageBox.Show("Register Berhasil !");
                halamanwelcome halawal = new halamanwelcome();
                this.Hide();
                halawal.Show();
            }
        }

        private void btrkembaliregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            halamanwelcome halamanwelcome = new halamanwelcome();
            halamanwelcome.Show();
        }
    }
}

