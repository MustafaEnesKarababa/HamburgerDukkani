using HamburgerDukkani.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerDukkani
{
    public partial class TumSiparisler : Form
    {
        public TumSiparisler()
        {
            InitializeComponent();
        }

        private void TumSiparisler_Load(object sender, EventArgs e)
        {
            int ciro = 0, ekstraMalzemeGeliri = 0,urunAdeti=0;
            
            foreach (Menu menu in MainMenu.menuler)
            {
                lbxTumSiparisler.Items.Add(menu);
                ciro += menu.ToplamFiyat;
                ekstraMalzemeGeliri += menu.Malzeme.Fiyat;
                urunAdeti += menu.Adet;
            }
            lblCiro.Text = $"₺{ciro}";
            lblSiparis.Text = $"{Menu.siparisSayisi}";
            lblEkstraGelir.Text = $"{ekstraMalzemeGeliri}";
            lblToplamUrun.Text = $"{urunAdeti}";
        }
    }
}
