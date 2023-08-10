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
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
            
        }

        public static List<Yiyecek> yiyecekler = new List<Yiyecek>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Yiyecek yiyecek = new Yiyecek();
            yiyecek.UrunAdi = tbxAd.Text;
            yiyecek.Fiyat = (int)nudFiyat.Value;
            yiyecekler.Add(yiyecek);
            Helper.Temizle(this.Controls);

        }

        private void MenuEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
