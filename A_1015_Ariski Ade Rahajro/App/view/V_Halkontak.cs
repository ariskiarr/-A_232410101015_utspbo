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
    public partial class V_Halkontak : Form
    {
        public V_Halkontak()
        {
            InitializeComponent();
            loaddata();
        }
        public void loaddata()
        {
            dataGridView1.AllowUserToAddRows = false;

            DataTable datakontak = C_TambahKontak.All();
            if (datakontak == null)
            {
                MessageBox.Show("Error: Gagal mengambil data Kontak");
                return;
            }

            dataGridView1.Columns.Clear();

            DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn();
            nomorColumn.HeaderText = "No";
            nomorColumn.Name = "nomor";
            dataGridView1.Columns.Add(nomorColumn);

            dataGridView1.DataSource = datakontak;
            if (dataGridView1.Columns["kontak_id"] != null) dataGridView1.Columns["kontak_id"].Visible = false;
            if (dataGridView1.Columns["nama"] != null)
                dataGridView1.Columns["nama"].HeaderText = "Nama";
            if (dataGridView1.Columns["email"] != null)
                dataGridView1.Columns["email"].HeaderText = "Email";
            if (dataGridView1.Columns["no_hp"] != null)
                dataGridView1.Columns["no_hp"].HeaderText = "Nomor Hp";


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["nomor"].Value = (i + 1).ToString();
            }
        }

        private void btkembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            halamanwelcome halamanwelcome = new halamanwelcome();
            halamanwelcome.Show();
        }
    }
}

