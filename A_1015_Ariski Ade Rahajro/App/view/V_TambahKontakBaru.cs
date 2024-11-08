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
    public partial class V_TambahKontakBaru : Form
    {
        public V_TambahKontakBaru()
        {
            InitializeComponent();
        }
        public bool Validasiinput()
        {
            if (string.IsNullOrWhiteSpace(tbnama.Text) ||
                string.IsNullOrWhiteSpace(tbemail.Text) ||
                string.IsNullOrWhiteSpace(tbnohp.Text))
            {
                return false;
            }
            return true;
        }
        private void bttambah_Click(object sender, EventArgs e)
        {
            if (!Validasiinput())
            {
                MessageBox.Show("Inputan tidak valid");
                return;
            }

            Kontak _kontak = new Kontak();
            {
                _kontak.nama = tbnama.Text;
                _kontak.email = tbemail.Text;
                _kontak.no_hp = tbnohp.Text;

                C_TambahKontak.addkontak(_kontak);
                MessageBox.Show("kontak Berhasil Dibuat !");
                halamanwelcome halawal = new halamanwelcome();
                this.Hide();
                halawal.Show();
            }
        }

        private void btkembalitbhkontak_Click(object sender, EventArgs e)
        {
            this.Hide();
            halamanwelcome halamanwelcome = new halamanwelcome();
            this.Hide();
        }
    }
}


