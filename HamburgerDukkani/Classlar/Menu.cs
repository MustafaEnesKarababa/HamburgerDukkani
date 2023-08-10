using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerDukkani.Classlar
{
    public class Menu
    {
        public Menu()
        {
            siparisSayisi++;
            Malzemeler = new List<Malzeme>();
        }
        public static int siparisSayisi = 0;
        public int ToplamFiyat { get; set; }
        public Yiyecek Yiyecek { get; set; }

        public Malzeme Malzeme { get; set; }
        public List<Malzeme> Malzemeler { get; set; }

        public int Adet { get; set; }

        public Boy Boy { get; set; }

        public override string ToString()
        {
            ToplamFiyat = Adet * ((Yiyecek.Fiyat + Malzeme.Fiyat + Boy.Fiyat));
            string bilgi = $"{Adet} adet {Yiyecek.UrunAdi}, {Boy.UrunAdi} boy, {Malzeme.UrunAdi} => Toplam Fiyat:₺{ToplamFiyat}";
            return bilgi;
        }
    }
}
