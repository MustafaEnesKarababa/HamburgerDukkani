namespace HamburgerDukkani
{
    partial class MenuEkle
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
            tbxAd = new TextBox();
            nudFiyat = new NumericUpDown();
            btnEkle = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 107);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 177);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 1;
            label2.Text = "Fiyat";
            // 
            // tbxAd
            // 
            tbxAd.Location = new Point(121, 103);
            tbxAd.Margin = new Padding(3, 4, 3, 4);
            tbxAd.Name = "tbxAd";
            tbxAd.Size = new Size(137, 27);
            tbxAd.TabIndex = 2;
            // 
            // nudFiyat
            // 
            nudFiyat.Location = new Point(121, 177);
            nudFiyat.Margin = new Padding(3, 4, 3, 4);
            nudFiyat.Name = "nudFiyat";
            nudFiyat.Size = new Size(137, 27);
            nudFiyat.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(82, 251);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(112, 49);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 44);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 5;
            label3.Text = "Menu Ekle";
            // 
            // MenuEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 336);
            Controls.Add(label3);
            Controls.Add(btnEkle);
            Controls.Add(nudFiyat);
            Controls.Add(tbxAd);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuEkle";
            Text = "UrunEkle";
            Load += MenuEkle_Load;
            ((System.ComponentModel.ISupportInitialize)nudFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbxAd;
        private NumericUpDown nudFiyat;
        private Button btnEkle;
        private Label label3;
    }
}