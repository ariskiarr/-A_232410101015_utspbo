namespace A_1015_Ariski_Ade_Rahajro.App.view
{
    partial class V_TambahKontakBaru
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbnama = new TextBox();
            tbemail = new TextBox();
            tbnohp = new TextBox();
            bttambah = new Button();
            btkembalitbhkontak = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(274, 30);
            label1.Name = "label1";
            label1.Size = new Size(237, 38);
            label1.TabIndex = 0;
            label1.Text = "Tambah Kontak";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 115);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 176);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 237);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 3;
            label4.Text = "Nomor Hp";
            // 
            // tbnama
            // 
            tbnama.Font = new Font("Segoe UI", 13F);
            tbnama.Location = new Point(200, 115);
            tbnama.Name = "tbnama";
            tbnama.Size = new Size(419, 42);
            tbnama.TabIndex = 4;
            // 
            // tbemail
            // 
            tbemail.Font = new Font("Segoe UI", 13F);
            tbemail.Location = new Point(200, 176);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(419, 42);
            tbemail.TabIndex = 5;
            // 
            // tbnohp
            // 
            tbnohp.Font = new Font("Segoe UI", 13F);
            tbnohp.Location = new Point(200, 237);
            tbnohp.Name = "tbnohp";
            tbnohp.Size = new Size(419, 42);
            tbnohp.TabIndex = 6;
            // 
            // bttambah
            // 
            bttambah.BackColor = Color.Lime;
            bttambah.ForeColor = Color.DarkGreen;
            bttambah.Location = new Point(652, 391);
            bttambah.Name = "bttambah";
            bttambah.Size = new Size(112, 34);
            bttambah.TabIndex = 7;
            bttambah.Text = "Tambah";
            bttambah.UseVisualStyleBackColor = false;
            bttambah.Click += bttambah_Click;
            // 
            // btkembalitbhkontak
            // 
            btkembalitbhkontak.BackColor = Color.Red;
            btkembalitbhkontak.ForeColor = SystemColors.ButtonFace;
            btkembalitbhkontak.Location = new Point(521, 391);
            btkembalitbhkontak.Name = "btkembalitbhkontak";
            btkembalitbhkontak.Size = new Size(112, 34);
            btkembalitbhkontak.TabIndex = 8;
            btkembalitbhkontak.Text = "Kembali";
            btkembalitbhkontak.UseVisualStyleBackColor = false;
            btkembalitbhkontak.Click += btkembalitbhkontak_Click;
            // 
            // V_TambahKontakBaru
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btkembalitbhkontak);
            Controls.Add(bttambah);
            Controls.Add(tbnohp);
            Controls.Add(tbemail);
            Controls.Add(tbnama);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "V_TambahKontakBaru";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_TambahKontakBaru";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbnama;
        private TextBox tbemail;
        private TextBox tbnohp;
        private Button bttambah;
        private Button btkembalitbhkontak;
    }
}