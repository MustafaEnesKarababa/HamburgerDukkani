using HamburgerDukkani.Classlar;
namespace HamburgerDukkani
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            menuler = new List<Menu>();
        }
        public static List<Menu> menuler;

        

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Yiyecek yiyecek1 = new Yiyecek();
            yiyecek1.UrunAdi = "BigMAC";
            yiyecek1.Fiyat = 160;
            MenuEkle.yiyecekler.Add(yiyecek1);

            Yiyecek yiyecek2 = new Yiyecek();
            yiyecek2.UrunAdi = "Whopper";
            yiyecek2.Fiyat = 190;
            MenuEkle.yiyecekler.Add(yiyecek2);


            Malzeme malzeme1 = new Malzeme();
            Malzeme malzeme2 = new Malzeme();
            malzeme1.UrunAdi = "Ketçap";
            malzeme2.UrunAdi = "Mayonez";
            malzeme1.Fiyat = 2;
            malzeme2.Fiyat = 3;
            EkstraMalzemeEkle.malzemeler.Add(malzeme1);
            EkstraMalzemeEkle.malzemeler.Add(malzeme2);
            SiparisOlustur();
            
        }
        private void sipariþOluþturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisOlustur();

        }

        private void tümSipariþlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            TumSiparisler tumSiparis = new();
            tumSiparis.MdiParent = this;
            tumSiparis.Dock = DockStyle.Fill;
            this.Width = tumSiparis.Width + 50;
            this.Height = tumSiparis.Height + 90;
            tumSiparis.Show();
        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            MenuEkle menuEkle = new();
            menuEkle.MdiParent = this;
            menuEkle.Dock = DockStyle.Fill;
            this.Width = menuEkle.Width + 50;
            this.Height = menuEkle.Height + 90;
            menuEkle.Show();
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            EkstraMalzemeEkle malzemeEkle = new();
            malzemeEkle.MdiParent = this;
            malzemeEkle.Dock = DockStyle.Fill;
            this.Width = malzemeEkle.Width + 50;
            this.Height = malzemeEkle.Height + 90;
            malzemeEkle.Show();
        }



        private void FormlariKapat()
        {
            Form[] forms = this.MdiChildren;
            foreach (Form form in forms)
            {
                form.Close();
            }
        }

        private void SiparisOlustur()
        {
            FormlariKapat();
            SiparisOlustur siparis = new();
            siparis.MdiParent = this;
            siparis.Dock = DockStyle.Fill;
            this.Width = siparis.Width + 50;
            this.Height = siparis.Height + 90;
            siparis.Show();
        }

    }
}