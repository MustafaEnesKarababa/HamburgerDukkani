﻿namespace HamburgerDukkani
{
    partial class MainMenu
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
            menuStrip1 = new MenuStrip();
            siparişYönetimiToolStripMenuItem = new ToolStripMenuItem();
            siparişOluşturToolStripMenuItem = new ToolStripMenuItem();
            tümSiparişlerToolStripMenuItem = new ToolStripMenuItem();
            ürünYönetimiToolStripMenuItem = new ToolStripMenuItem();
            menüEkleToolStripMenuItem = new ToolStripMenuItem();
            ekstraMalzemeEkleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { siparişYönetimiToolStripMenuItem, ürünYönetimiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { siparişOluşturToolStripMenuItem, tümSiparişlerToolStripMenuItem });
            siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            siparişYönetimiToolStripMenuItem.Size = new Size(129, 24);
            siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // siparişOluşturToolStripMenuItem
            // 
            siparişOluşturToolStripMenuItem.Name = "siparişOluşturToolStripMenuItem";
            siparişOluşturToolStripMenuItem.Size = new Size(187, 26);
            siparişOluşturToolStripMenuItem.Text = "Sipariş Oluştur";
            siparişOluşturToolStripMenuItem.Click += siparişOluşturToolStripMenuItem_Click;
            // 
            // tümSiparişlerToolStripMenuItem
            // 
            tümSiparişlerToolStripMenuItem.Name = "tümSiparişlerToolStripMenuItem";
            tümSiparişlerToolStripMenuItem.Size = new Size(187, 26);
            tümSiparişlerToolStripMenuItem.Text = "Tüm Siparişler";
            tümSiparişlerToolStripMenuItem.Click += tümSiparişlerToolStripMenuItem_Click;
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menüEkleToolStripMenuItem, ekstraMalzemeEkleToolStripMenuItem });
            ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            ürünYönetimiToolStripMenuItem.Size = new Size(116, 24);
            ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // menüEkleToolStripMenuItem
            // 
            menüEkleToolStripMenuItem.Name = "menüEkleToolStripMenuItem";
            menüEkleToolStripMenuItem.Size = new Size(227, 26);
            menüEkleToolStripMenuItem.Text = "Menü Ekle";
            menüEkleToolStripMenuItem.Click += menüEkleToolStripMenuItem_Click;
            // 
            // ekstraMalzemeEkleToolStripMenuItem
            // 
            ekstraMalzemeEkleToolStripMenuItem.Name = "ekstraMalzemeEkleToolStripMenuItem";
            ekstraMalzemeEkleToolStripMenuItem.Size = new Size(227, 26);
            ekstraMalzemeEkleToolStripMenuItem.Text = "Ekstra Malzeme Ekle";
            ekstraMalzemeEkleToolStripMenuItem.Click += ekstraMalzemeEkleToolStripMenuItem_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private ToolStripMenuItem siparişOluşturToolStripMenuItem;
        private ToolStripMenuItem tümSiparişlerToolStripMenuItem;
        private ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private ToolStripMenuItem menüEkleToolStripMenuItem;
        private ToolStripMenuItem ekstraMalzemeEkleToolStripMenuItem;
    }
}