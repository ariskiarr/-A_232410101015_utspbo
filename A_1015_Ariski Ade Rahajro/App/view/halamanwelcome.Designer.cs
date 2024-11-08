namespace A_1015_Ariski_Ade_Rahajro
{
    partial class halamanwelcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbwelcome = new Label();
            bthalkontak = new Button();
            bthalregister = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbwelcome
            // 
            lbwelcome.AutoSize = true;
            lbwelcome.Font = new Font("Sitka Subheading", 20F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbwelcome.Location = new Point(178, 39);
            lbwelcome.Name = "lbwelcome";
            lbwelcome.Size = new Size(446, 58);
            lbwelcome.TabIndex = 0;
            lbwelcome.Text = "SELAMAT DATANG BRO";
            // 
            // bthalkontak
            // 
            bthalkontak.Location = new Point(197, 145);
            bthalkontak.Name = "bthalkontak";
            bthalkontak.Size = new Size(414, 55);
            bthalkontak.TabIndex = 1;
            bthalkontak.Text = "Halaman Kontak";
            bthalkontak.UseVisualStyleBackColor = true;
            bthalkontak.Click += bthalkontak_Click;
            // 
            // bthalregister
            // 
            bthalregister.Location = new Point(197, 217);
            bthalregister.Name = "bthalregister";
            bthalregister.Size = new Size(414, 55);
            bthalregister.TabIndex = 2;
            bthalregister.Text = "Halaman Register";
            bthalregister.UseVisualStyleBackColor = true;
            bthalregister.Click += bthalregister_Click;
            // 
            // button1
            // 
            button1.Location = new Point(197, 292);
            button1.Name = "button1";
            button1.Size = new Size(414, 55);
            button1.TabIndex = 3;
            button1.Text = "Halaman Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // halamanwelcome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(bthalregister);
            Controls.Add(bthalkontak);
            Controls.Add(lbwelcome);
            Name = "halamanwelcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbwelcome;
        private Button bthalkontak;
        private Button bthalregister;
        private Button button1;
    }
}
