using A_1015_Ariski_Ade_Rahajro.App.context;
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
    public partial class V_HalLogin : Form
    {
        public V_HalLogin()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_TambahKontakBaru tambahkontakbaru = new V_TambahKontakBaru();
            tambahkontakbaru.Show();





        }

        private void btkembalilogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            halamanwelcome halamanwelcome = new halamanwelcome();
            halamanwelcome.Show();  
        }
    }
}
