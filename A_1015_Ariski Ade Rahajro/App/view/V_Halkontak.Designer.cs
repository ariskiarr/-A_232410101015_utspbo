namespace A_1015_Ariski_Ade_Rahajro.App.view
{
    partial class V_Halkontak
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
            dataGridView1 = new DataGridView();
            lbhalkontak = new Label();
            btkembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(739, 315);
            dataGridView1.TabIndex = 0;
            // 
            // lbhalkontak
            // 
            lbhalkontak.AutoSize = true;
            lbhalkontak.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbhalkontak.Location = new Point(255, 9);
            lbhalkontak.Name = "lbhalkontak";
            lbhalkontak.Size = new Size(291, 41);
            lbhalkontak.TabIndex = 1;
            lbhalkontak.Text = "HALAMAN KONTAK";
            // 
            // btkembali
            // 
            btkembali.BackColor = Color.Red;
            btkembali.ForeColor = SystemColors.ButtonFace;
            btkembali.Location = new Point(651, 404);
            btkembali.Name = "btkembali";
            btkembali.Size = new Size(112, 34);
            btkembali.TabIndex = 2;
            btkembali.Text = "Kembali";
            btkembali.UseVisualStyleBackColor = false;
            btkembali.Click += btkembali_Click;
            // 
            // V_Halkontak
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btkembali);
            Controls.Add(lbhalkontak);
            Controls.Add(dataGridView1);
            Name = "V_Halkontak";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Halkontak";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lbhalkontak;
        private Button btkembali;
    }
}