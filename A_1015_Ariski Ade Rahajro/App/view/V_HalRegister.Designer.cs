namespace A_1015_Ariski_Ade_Rahajro.App.view
{
    partial class V_HalRegister
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
            tbusernameregister = new TextBox();
            tbpasswordregister = new TextBox();
            bttregister = new Button();
            btrkembaliregister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(337, 53);
            label1.Name = "label1";
            label1.Size = new Size(125, 38);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 137);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 217);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // tbusernameregister
            // 
            tbusernameregister.Font = new Font("Segoe UI", 13F);
            tbusernameregister.Location = new Point(257, 137);
            tbusernameregister.Name = "tbusernameregister";
            tbusernameregister.Size = new Size(342, 42);
            tbusernameregister.TabIndex = 3;
            // 
            // tbpasswordregister
            // 
            tbpasswordregister.Font = new Font("Segoe UI", 13F);
            tbpasswordregister.Location = new Point(257, 205);
            tbpasswordregister.Name = "tbpasswordregister";
            tbpasswordregister.Size = new Size(342, 42);
            tbpasswordregister.TabIndex = 4;
            // 
            // bttregister
            // 
            bttregister.BackColor = Color.Lime;
            bttregister.ForeColor = Color.DarkGreen;
            bttregister.Location = new Point(654, 371);
            bttregister.Name = "bttregister";
            bttregister.Size = new Size(112, 34);
            bttregister.TabIndex = 5;
            bttregister.Text = "Register";
            bttregister.UseVisualStyleBackColor = false;
            bttregister.Click += bttregister_Click;
            // 
            // btrkembaliregister
            // 
            btrkembaliregister.BackColor = Color.Red;
            btrkembaliregister.ForeColor = SystemColors.ButtonFace;
            btrkembaliregister.Location = new Point(521, 371);
            btrkembaliregister.Name = "btrkembaliregister";
            btrkembaliregister.Size = new Size(112, 34);
            btrkembaliregister.TabIndex = 6;
            btrkembaliregister.Text = "Kembali";
            btrkembaliregister.UseVisualStyleBackColor = false;
            btrkembaliregister.Click += btrkembaliregister_Click;
            // 
            // V_HalRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btrkembaliregister);
            Controls.Add(bttregister);
            Controls.Add(tbpasswordregister);
            Controls.Add(tbusernameregister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "V_HalRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_HalRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbusernameregister;
        private TextBox tbpasswordregister;
        private Button bttregister;
        private Button btrkembaliregister;
    }
}