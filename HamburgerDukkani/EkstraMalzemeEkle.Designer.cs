namespace HamburgerDukkani
{
    partial class EkstraMalzemeEkle
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
            btnEkstraMalzemeEkle = new Button();
            txtMalzemeAd = new TextBox();
            nudMalzemeFiyat = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMalzemeFiyat).BeginInit();
            SuspendLayout();
            // 
            // btnEkstraMalzemeEkle
            // 
            btnEkstraMalzemeEkle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkstraMalzemeEkle.Location = new Point(128, 279);
            btnEkstraMalzemeEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkstraMalzemeEkle.Name = "btnEkstraMalzemeEkle";
            btnEkstraMalzemeEkle.Size = new Size(218, 59);
            btnEkstraMalzemeEkle.TabIndex = 10;
            btnEkstraMalzemeEkle.Text = "Ekle";
            btnEkstraMalzemeEkle.UseVisualStyleBackColor = true;
            btnEkstraMalzemeEkle.Click += btnEkstraMalzemeEkle_Click;
            // 
            // txtMalzemeAd
            // 
            txtMalzemeAd.Location = new Point(128, 113);
            txtMalzemeAd.Margin = new Padding(3, 4, 3, 4);
            txtMalzemeAd.Name = "txtMalzemeAd";
            txtMalzemeAd.Size = new Size(218, 27);
            txtMalzemeAd.TabIndex = 9;
            // 
            // nudMalzemeFiyat
            // 
            nudMalzemeFiyat.Location = new Point(128, 191);
            nudMalzemeFiyat.Margin = new Padding(3, 4, 3, 4);
            nudMalzemeFiyat.Name = "nudMalzemeFiyat";
            nudMalzemeFiyat.Size = new Size(218, 27);
            nudMalzemeFiyat.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 188);
            label3.Name = "label3";
            label3.Size = new Size(64, 32);
            label3.TabIndex = 7;
            label3.Text = "Fiyat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 113);
            label2.Name = "label2";
            label2.Size = new Size(43, 32);
            label2.TabIndex = 6;
            label2.Text = "Ad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 37);
            label1.Name = "label1";
            label1.Size = new Size(231, 32);
            label1.TabIndex = 11;
            label1.Text = "Ekstra Malzeme Ekle";
            // 
            // EkstraMalzemeEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 441);
            Controls.Add(label1);
            Controls.Add(btnEkstraMalzemeEkle);
            Controls.Add(txtMalzemeAd);
            Controls.Add(nudMalzemeFiyat);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EkstraMalzemeEkle";
            Text = "EkstraMalzemeEkle";
            Load += EkstraMalzemeEkle_Load;
            ((System.ComponentModel.ISupportInitialize)nudMalzemeFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkstraMalzemeEkle;
        private TextBox txtMalzemeAd;
        private NumericUpDown nudMalzemeFiyat;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}