namespace HamburgerDukkani
{
    partial class TumSiparisler
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
            lblCiro = new Label();
            lblSiparis = new Label();
            lblEkstraGelir = new Label();
            lbxTumSiparisler = new ListBox();
            label8 = new Label();
            lblToplamUrun = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 16);
            label1.Name = "label1";
            label1.Size = new Size(165, 32);
            label1.TabIndex = 0;
            label1.Text = "Tüm Siparişler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(425, 29);
            label2.Name = "label2";
            label2.Size = new Size(57, 32);
            label2.TabIndex = 1;
            label2.Text = "Ciro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(425, 160);
            label3.Name = "label3";
            label3.Size = new Size(173, 32);
            label3.TabIndex = 2;
            label3.Text = "Toplam Siparis:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(425, 309);
            label4.Name = "label4";
            label4.Size = new Size(243, 32);
            label4.TabIndex = 3;
            label4.Text = "Ekstra Malzeme Geliri";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCiro.ForeColor = Color.Red;
            lblCiro.Location = new Point(536, 91);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(34, 28);
            lblCiro.TabIndex = 4;
            lblCiro.Text = "₺0";
            // 
            // lblSiparis
            // 
            lblSiparis.AutoSize = true;
            lblSiparis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSiparis.ForeColor = Color.Red;
            lblSiparis.Location = new Point(536, 244);
            lblSiparis.Name = "lblSiparis";
            lblSiparis.Size = new Size(23, 28);
            lblSiparis.TabIndex = 5;
            lblSiparis.Text = "0";
            // 
            // lblEkstraGelir
            // 
            lblEkstraGelir.AutoSize = true;
            lblEkstraGelir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEkstraGelir.ForeColor = Color.Red;
            lblEkstraGelir.Location = new Point(536, 400);
            lblEkstraGelir.Name = "lblEkstraGelir";
            lblEkstraGelir.Size = new Size(34, 28);
            lblEkstraGelir.TabIndex = 6;
            lblEkstraGelir.Text = "₺0";
            // 
            // lbxTumSiparisler
            // 
            lbxTumSiparisler.FormattingEnabled = true;
            lbxTumSiparisler.ItemHeight = 20;
            lbxTumSiparisler.Location = new Point(14, 53);
            lbxTumSiparisler.Margin = new Padding(3, 4, 3, 4);
            lbxTumSiparisler.Name = "lbxTumSiparisler";
            lbxTumSiparisler.Size = new Size(374, 524);
            lbxTumSiparisler.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(435, 457);
            label8.Name = "label8";
            label8.Size = new Size(213, 32);
            label8.TabIndex = 8;
            label8.Text = "Satılan Urun Adedi";
            // 
            // lblToplamUrun
            // 
            lblToplamUrun.AutoSize = true;
            lblToplamUrun.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblToplamUrun.ForeColor = Color.Red;
            lblToplamUrun.Location = new Point(539, 532);
            lblToplamUrun.Name = "lblToplamUrun";
            lblToplamUrun.Size = new Size(23, 28);
            lblToplamUrun.TabIndex = 9;
            lblToplamUrun.Text = "0";
            // 
            // TumSiparisler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 600);
            Controls.Add(lblToplamUrun);
            Controls.Add(label8);
            Controls.Add(lbxTumSiparisler);
            Controls.Add(lblEkstraGelir);
            Controls.Add(lblSiparis);
            Controls.Add(lblCiro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TumSiparisler";
            Text = "AlinanSiparisler";
            Load += TumSiparisler_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblCiro;
        private Label lblSiparis;
        private Label lblEkstraGelir;
        private ListBox lbxTumSiparisler;
        private Label label8;
        private Label lblToplamUrun;
    }
}