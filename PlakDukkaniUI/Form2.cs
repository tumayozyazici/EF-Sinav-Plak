using PlakDükkaniDATA.Entities;
using PlakDukkaniREPO.Context;
using PlakDukkaniSERVICE.Concrete;
using PlakDukkaniSERVICE.Interface;
using PlakDukkaniUI.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkaniUI
{
    public partial class Form2 : Form
    {
        IAlbumSERVICE albumSERVICE;
        public Form2()
        {
            InitializeComponent();
            albumSERVICE = new AlbumSERVICE();
        }

        private void btnSatisDurmus_Click(object sender, EventArgs e)
        {
            var result = albumSERVICE.SatisiDurmusAlbumler(false);
            ListeDoldur(result);
        }

        private void btnSatisDevam_Click(object sender, EventArgs e)
        {
            var result = albumSERVICE.SatisiDurmusAlbumler(true);
            ListeDoldur(result);
        }

        private void btnEklenenSonOn_Click(object sender, EventArgs e)
        {
            var result = albumSERVICE.EklenenSonOnAlbum();
            ListeDoldur(result);
        }

        private void btnIndirimdekiAlbumler_Click(object sender, EventArgs e)
        {
            var result = albumSERVICE.IndirimleriGetir();
            ListeDoldur(result);
        }

        private void btnAlbumGetir_Click(object sender, EventArgs e)
        {
            var result = albumSERVICE.GetAll();
            ListeDoldur(result);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Album album = new Album();
            album.DukkanID = 1;
            albumSERVICE.Add(AlbumOlusturGuncelle(album));
            MessageBox.Show("Eklendi!");
            HelperClass.Temizle(this.Controls);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Album album = (Album)lst_liste.SelectedItems[0].Tag;
            albumSERVICE.Update(AlbumOlusturGuncelle(album));
            MessageBox.Show("Güncellendi!!");
            HelperClass.Temizle(this.Controls);
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (lst_liste.SelectedItems.Count > 0)
            {
                Album album = (Album)lst_liste.SelectedItems[0].Tag;
                albumSERVICE.Delete(album);
                MessageBox.Show("Album Silindi!!");
                HelperClass.Temizle(this.Controls);
            }
        }

        private void lst_liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_liste.SelectedItems.Count > 0)
            {
                Album album = (Album)lst_liste.SelectedItems[0].Tag;
                txtAlbumAdi.Text = album.Adi;
                txtSanatci.Text = album.Sanatci;
                txtFiyat.Text = album.Fiyati.ToString();
                txtIndirimOrani.Text = album.IndirimOrani.ToString();
                dpCikisTarihi.Value = album.CikisTarihi;
                cbSatisDevamMi.Checked = album.SatisDevamMi ? true : false;
            }
        }

        private Album AlbumOlusturGuncelle(Album album)
        {
            try
            {
                album.Adi = txtAlbumAdi.Text;
                album.Sanatci = txtSanatci.Text;
                album.CikisTarihi = dpCikisTarihi.Value;
                album.Fiyati = Convert.ToDouble(txtFiyat.Text);
                album.IndirimOrani = Convert.ToDouble(txtIndirimOrani.Text);
                album.SatisDevamMi = cbSatisDevamMi.Checked ? true : false;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen verileri eksiksiz giriniz.");
            }
            return album;
        }

        private void ListeDoldur(List<Album> result)
        {
            lst_liste.Items.Clear();
            foreach (var item in result)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = item.Adi;
                lst.SubItems.Add(item.Sanatci);
                lst.Tag = item;
                lst_liste.Items.Add(lst);
            }
        }
    }
}
