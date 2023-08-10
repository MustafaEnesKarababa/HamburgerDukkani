namespace HamburgerDukkani
{
    partial class SiparisOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisOlustur));
            flyo = new FlowLayoutPanel();
            cboxUrunler = new ComboBox();
            pictureBox1 = new PictureBox();
            lboxUrunler = new ListBox();
            rbKucuk = new RadioButton();
            rbOrta = new RadioButton();
            rbBuyuk = new RadioButton();
            label1 = new Label();
            nudAdet = new NumericUpDown();
            btnEkle = new Button();
            lblGenelToplam = new Label();
            btnSiparisOnayla = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            SuspendLayout();
            // 
            // flyo
            // 
            flyo.Location = new Point(41, 331);
            flyo.Margin = new Padding(3, 4, 3, 4);
            flyo.Name = "flyo";
            flyo.Size = new Size(219, 231);
            flyo.TabIndex = 0;
            // 
            // cboxUrunler
            // 
            cboxUrunler.FormattingEnabled = true;
            cboxUrunler.Location = new Point(41, 281);
            cboxUrunler.Margin = new Padding(3, 4, 3, 4);
            cboxUrunler.Name = "cboxUrunler";
            cboxUrunler.Size = new Size(206, 28);
            cboxUrunler.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(54, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lboxUrunler
            // 
            lboxUrunler.FormattingEnabled = true;
            lboxUrunler.ItemHeight = 20;
            lboxUrunler.Location = new Point(336, 16);
            lboxUrunler.Margin = new Padding(3, 4, 3, 4);
            lboxUrunler.Name = "lboxUrunler";
            lboxUrunler.Size = new Size(591, 504);
            lboxUrunler.TabIndex = 0;
            // 
            // rbKucuk
            // 
            rbKucuk.AutoSize = true;
            rbKucuk.Location = new Point(11, 596);
            rbKucuk.Margin = new Padding(3, 4, 3, 4);
            rbKucuk.Name = "rbKucuk";
            rbKucuk.Size = new Size(69, 24);
            rbKucuk.TabIndex = 1;
            rbKucuk.TabStop = true;
            rbKucuk.Text = "Küçük";
            rbKucuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            rbOrta.AutoSize = true;
            rbOrta.Location = new Point(96, 596);
            rbOrta.Margin = new Padding(3, 4, 3, 4);
            rbOrta.Name = "rbOrta";
            rbOrta.Size = new Size(59, 24);
            rbOrta.TabIndex = 2;
            rbOrta.TabStop = true;
            rbOrta.Text = "Orta";
            rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbBuyuk
            // 
            rbBuyuk.AutoSize = true;
            rbBuyuk.Location = new Point(161, 596);
            rbBuyuk.Margin = new Padding(3, 4, 3, 4);
            rbBuyuk.Name = "rbBuyuk";
            rbBuyuk.Size = new Size(69, 24);
            rbBuyuk.TabIndex = 3;
            rbBuyuk.TabStop = true;
            rbBuyuk.Text = "Büyük";
            rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 656);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 4;
            label1.Text = "Adet";
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(96, 653);
            nudAdet.Margin = new Padding(3, 4, 3, 4);
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(137, 27);
            nudAdet.TabIndex = 5;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(27, 707);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(222, 69);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // lblGenelToplam
            // 
            lblGenelToplam.AutoSize = true;
            lblGenelToplam.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenelToplam.Location = new Point(466, 641);
            lblGenelToplam.Name = "lblGenelToplam";
            lblGenelToplam.Size = new Size(0, 32);
            lblGenelToplam.TabIndex = 7;
            // 
            // btnSiparisOnayla
            // 
            btnSiparisOnayla.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiparisOnayla.Location = new Point(686, 581);
            btnSiparisOnayla.Margin = new Padding(3, 4, 3, 4);
            btnSiparisOnayla.Name = "btnSiparisOnayla";
            btnSiparisOnayla.Size = new Size(221, 161);
            btnSiparisOnayla.TabIndex = 9;
            btnSiparisOnayla.Text = "Siparisi Onayla";
            btnSiparisOnayla.UseVisualStyleBackColor = true;
            btnSiparisOnayla.Click += btnSiparisOnayla_Click;
            // 
            // SiparisOlustur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 792);
            Controls.Add(cboxUrunler);
            Controls.Add(btnSiparisOnayla);
            Controls.Add(lblGenelToplam);
            Controls.Add(btnEkle);
            Controls.Add(nudAdet);
            Controls.Add(label1);
            Controls.Add(rbBuyuk);
            Controls.Add(rbOrta);
            Controls.Add(rbKucuk);
            Controls.Add(lboxUrunler);
            Controls.Add(pictureBox1);
            Controls.Add(flyo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SiparisOlustur";
            Text = "SiparisEkrani";
            Load += SiparisOlustur_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flyo;
        private ComboBox cboxUrunler;
        private CheckBox checkBox2;
        private PictureBox pictureBox1;
        private ListBox lboxUrunler;
        private RadioButton rbKucuk;
        private RadioButton rbOrta;
        private RadioButton rbBuyuk;
        private Label label1;
        private NumericUpDown nudAdet;
        private Button btnEkle;
        private Label lblGenelToplam;
        private Button btnSiparisOnayla;
    }
}