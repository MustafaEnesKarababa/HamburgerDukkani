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
    public partial class EkstraMalzemeEkle : Form
    {
        public EkstraMalzemeEkle()
        {
            InitializeComponent();
        }

        public static List<Malzeme> malzemeler = new List<Malzeme>();


        private void btnEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {


            Malzeme malzeme = new Malzeme();
            malzeme.UrunAdi = txtMalzemeAd.Text;
            malzeme.Fiyat = (int)nudMalzemeFiyat.Value;

            malzemeler.Add(malzeme);
            Helper.Temizle(this.Controls);


        }

        private void EkstraMalzemeEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
