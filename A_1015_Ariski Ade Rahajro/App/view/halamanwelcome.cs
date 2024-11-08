using A_1015_Ariski_Ade_Rahajro.App.view;

namespace A_1015_Ariski_Ade_Rahajro
{
    public partial class halamanwelcome : Form
    {
        public halamanwelcome()
        {
            InitializeComponent();
        }

        private void bthalregister_Click(object sender, EventArgs e)
        {
            V_HalRegister halRegister = new V_HalRegister();

            this.Hide();
            halRegister.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_HalLogin halLogin = new V_HalLogin();
            halLogin.Show();
        }

        private void bthalkontak_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Halkontak halkontak = new V_Halkontak();
            halkontak.Show();
        }
    }
}
