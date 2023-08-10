using HamburgerDukkani.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerDukkani
{
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();


        }



        private void SiparisOlustur_Load(object sender, EventArgs e)
        {



            foreach (Yiyecek yiyecek in MenuEkle.yiyecekler.Distinct())
            {
                cboxUrunler.Items.Add(yiyecek.UrunAdi);
            }

            foreach (Malzeme malzeme in EkstraMalzemeEkle.malzemeler.Distinct())
            {
                CheckBox chk = new CheckBox();
                chk.Text = malzeme.UrunAdi;
                chk.Tag = malzeme;
                flyo.Controls.Add(chk);

            }
            cboxUrunler.SelectedIndex = 0;

        }

        
        List<Menu> anlikMenu = new List<Menu>();    
        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            lboxUrunler.Items.Clear();
            Menu menu = new Menu();
            Yiyecek yiyecek = new Yiyecek();
            Malzeme malzeme = new Malzeme();
            Boy boy = new Boy();

            yiyecek.UrunAdi = cboxUrunler.SelectedItem.ToString();


            foreach (Yiyecek yemek in MenuEkle.yiyecekler)
            {
                if (yemek.UrunAdi == yiyecek.UrunAdi)
                {
                    yiyecek.Fiyat = yemek.Fiyat;
                }
            }


            foreach (Control control in this.flyo.Controls)
            {
                if (control is CheckBox)
                {

                    CheckBox cb;
                    cb = (CheckBox)control;
                    if (cb.Checked)
                    {
                       
                        malzeme.UrunAdi = cb.Text;
                        //malzeme = (Malzeme)cb.Tag; 
                    }

                }
            }

            foreach (Malzeme malzemem in EkstraMalzemeEkle.malzemeler)
            {
                if (malzemem.UrunAdi == malzeme.UrunAdi)
                {
                    malzeme.Fiyat = malzemem.Fiyat;
                }
            }



            if (rbBuyuk.Checked)
            {
                boy.UrunAdi = rbBuyuk.Text;
                boy.Fiyat = 10;
            }
            else if (rbOrta.Checked)
            {
                boy.UrunAdi = rbOrta.Text;
                boy.Fiyat = 6;
            }
            else
            {
                boy.UrunAdi = rbKucuk.Text;
                boy.Fiyat = 5;

            }

            menu.Adet = (int)nudAdet.Value;
            menu.Yiyecek = yiyecek;
            menu.Malzeme = malzeme;
            menu.Boy = boy;
            anlikMenu.Add(menu);
            MainMenu.menuler.Add(menu);


            int ToplamSiparisTutari = 0;
            foreach (Menu menum in anlikMenu)
            {
                lboxUrunler.Items.Add(menum);
                ToplamSiparisTutari += menum.ToplamFiyat;
            }
            lblGenelToplam.Text = $"Toplam tutar:{ToplamSiparisTutari} ₺";
        }

        private void btnSiparisOnayla_Click(object sender, EventArgs e)
        {
            Helper.Temizle(this.Controls);
        }
    }

}
