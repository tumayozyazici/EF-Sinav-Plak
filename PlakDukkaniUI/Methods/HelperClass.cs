using PlakDukkaniSERVICE.Concrete;
using PlakDükkaniDATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlakDukkaniSERVICE.Interface;
using System.Security.Cryptography;

namespace PlakDukkaniUI.Methods
{
    public class HelperClass
    {
        static IYoneticiSERVICE yoneticiSERVICE = new YoneticiSERVICE();

        public static void KayitKontrolu(string kullaniciAdi, string sifre, string sifreTekrari)
        {
            if (!yoneticiSERVICE.YoneticiVarMi(kullaniciAdi))
            {
                if (sifre == sifreTekrari)
                {
                    if (sifre.Length < 8 || sifre.Count(char.IsUpper) < 2 || sifre.Count(char.IsLower) < 3 || sifre.Count(c => "!:+*".Contains(c)) < 2)
                        MessageBox.Show("Şifre istenilen kriterleri karşılamıyor");
                    else
                    {
                        Yonetici yonetici = new Yonetici();
                        yonetici.KullaniciAdi = kullaniciAdi;
                        yonetici.Password = sha256_hash(sifreTekrari);
                        yonetici.DukkanID = 1;
                        yoneticiSERVICE.Add(yonetici);
                        MessageBox.Show("Kayıt işlemi başarılı!");
                    }
                }
                else
                    MessageBox.Show("Şifreler aynı olmalı");
            }
            else
                MessageBox.Show("Zaten böyle bir kullanıcı var");
        }

        public static string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            { 
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            } 
        }

        public static void Temizle(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
            }
        }
    }
}
