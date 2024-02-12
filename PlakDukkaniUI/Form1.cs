using PlakDükkaniDATA.Entities;
using PlakDukkaniREPO.Context;
using PlakDukkaniSERVICE.Concrete;
using PlakDukkaniSERVICE.Interface;
using PlakDukkaniUI.Methods;

namespace PlakDukkaniUI
{
    public partial class Form1 : Form
    {
        IYoneticiSERVICE yoneticiSERVICE;
        public Form1()
        {
            InitializeComponent();
            yoneticiSERVICE = new YoneticiSERVICE();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var result = yoneticiSERVICE.GetWhere(x => x.KullaniciAdi == txtGirisKullaniciAdi.Text && x.Password == HelperClass.sha256_hash(txtGirisSifre.Text)).Count();

            if (result != 0)
            {
                Form2 frm = new Form2();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Hatalý kullanýcý adý veya þifre giriþi yaptýnýz");
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            HelperClass.KayitKontrolu(txtKayitKullaniciAdi.Text,txtKayitSifre.Text,txtDogrulamaSifre.Text);
        }
    }
}
