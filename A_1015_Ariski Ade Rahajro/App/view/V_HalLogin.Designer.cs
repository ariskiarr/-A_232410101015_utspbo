namespace A_1015_Ariski_Ade_Rahajro.App.view
{
    partial class V_HalLogin
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
            lbusername = new Label();
            lbpassword = new Label();
            tbusername = new TextBox();
            tbpassword = new TextBox();
            btkembalilogin = new Button();
            btlogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(356, 66);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // lbusername
            // 
            lbusername.AutoSize = true;
            lbusername.Font = new Font("Segoe UI", 10F);
            lbusername.Location = new Point(133, 164);
            lbusername.Name = "lbusername";
            lbusername.Size = new Size(99, 28);
            lbusername.TabIndex = 1;
            lbusername.Text = "Username";
            // 
            // lbpassword
            // 
            lbpassword.AutoSize = true;
            lbpassword.Font = new Font("Segoe UI", 10F);
            lbpassword.Location = new Point(133, 242);
            lbpassword.Name = "lbpassword";
            lbpassword.Size = new Size(93, 28);
            lbpassword.TabIndex = 2;
            lbpassword.Text = "Password";
            // 
            // tbusername
            // 
            tbusername.Font = new Font("Segoe UI", 13F);
            tbusername.Location = new Point(254, 164);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(382, 42);
            tbusername.TabIndex = 3;
            // 
            // tbpassword
            // 
            tbpassword.Font = new Font("Segoe UI", 13F);
            tbpassword.Location = new Point(254, 233);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(382, 42);
            tbpassword.TabIndex = 4;
            // 
            // btkembalilogin
            // 
            btkembalilogin.BackColor = Color.Red;
            btkembalilogin.ForeColor = SystemColors.ButtonFace;
            btkembalilogin.Location = new Point(540, 393);
            btkembalilogin.Name = "btkembalilogin";
            btkembalilogin.Size = new Size(112, 34);
            btkembalilogin.TabIndex = 5;
            btkembalilogin.Text = "Kembali";
            btkembalilogin.UseVisualStyleBackColor = false;
            btkembalilogin.Click += btkembalilogin_Click;
            // 
            // btlogin
            // 
            btlogin.BackColor = Color.Lime;
            btlogin.ForeColor = Color.DarkGreen;
            btlogin.Location = new Point(676, 393);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(112, 34);
            btlogin.TabIndex = 6;
            btlogin.Text = "Login";
            btlogin.UseVisualStyleBackColor = false;
            btlogin.Click += btlogin_Click;
            // 
            // V_HalLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btlogin);
            Controls.Add(btkembalilogin);
            Controls.Add(tbpassword);
            Controls.Add(tbusername);
            Controls.Add(lbpassword);
            Controls.Add(lbusername);
            Controls.Add(label1);
            Name = "V_HalLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_HalLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbusername;
        private Label lbpassword;
        private TextBox tbusername;
        private TextBox tbpassword;
        private Button btkembalilogin;
        private Button btlogin;
    }
}