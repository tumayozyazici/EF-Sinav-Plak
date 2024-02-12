namespace PlakDukkaniUI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSatisDurmus = new Button();
            btnSatisDevam = new Button();
            btnEklenenSonOn = new Button();
            btnIndirimdekiAlbumler = new Button();
            btnAlbumGetir = new Button();
            btnEkle = new Button();
            btnGuncelle = new Button();
            Sil = new Button();
            txtAlbumAdi = new TextBox();
            txtFiyat = new TextBox();
            txtSanatci = new TextBox();
            txtIndirimOrani = new TextBox();
            dpCikisTarihi = new DateTimePicker();
            cbSatisDevamMi = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lst_liste = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // btnSatisDurmus
            // 
            btnSatisDurmus.Location = new Point(12, 333);
            btnSatisDurmus.Name = "btnSatisDurmus";
            btnSatisDurmus.Size = new Size(137, 49);
            btnSatisDurmus.TabIndex = 0;
            btnSatisDurmus.Text = "Satışı Durmuş";
            btnSatisDurmus.UseVisualStyleBackColor = true;
            btnSatisDurmus.Click += btnSatisDurmus_Click;
            // 
            // btnSatisDevam
            // 
            btnSatisDevam.Location = new Point(155, 333);
            btnSatisDevam.Name = "btnSatisDevam";
            btnSatisDevam.Size = new Size(137, 49);
            btnSatisDevam.TabIndex = 1;
            btnSatisDevam.Text = "Satışı Devam Eden";
            btnSatisDevam.UseVisualStyleBackColor = true;
            btnSatisDevam.Click += btnSatisDevam_Click;
            // 
            // btnEklenenSonOn
            // 
            btnEklenenSonOn.Location = new Point(298, 333);
            btnEklenenSonOn.Name = "btnEklenenSonOn";
            btnEklenenSonOn.Size = new Size(137, 49);
            btnEklenenSonOn.TabIndex = 2;
            btnEklenenSonOn.Text = "Eklenen Son 10 Albüm";
            btnEklenenSonOn.UseVisualStyleBackColor = true;
            btnEklenenSonOn.Click += btnEklenenSonOn_Click;
            // 
            // btnIndirimdekiAlbumler
            // 
            btnIndirimdekiAlbumler.Location = new Point(441, 333);
            btnIndirimdekiAlbumler.Name = "btnIndirimdekiAlbumler";
            btnIndirimdekiAlbumler.Size = new Size(137, 49);
            btnIndirimdekiAlbumler.TabIndex = 3;
            btnIndirimdekiAlbumler.Text = "İndirimdeki Albümler";
            btnIndirimdekiAlbumler.UseVisualStyleBackColor = true;
            btnIndirimdekiAlbumler.Click += btnIndirimdekiAlbumler_Click;
            // 
            // btnAlbumGetir
            // 
            btnAlbumGetir.Location = new Point(584, 333);
            btnAlbumGetir.Name = "btnAlbumGetir";
            btnAlbumGetir.Size = new Size(137, 49);
            btnAlbumGetir.TabIndex = 5;
            btnAlbumGetir.Text = "Tüm Albümleri Getir";
            btnAlbumGetir.UseVisualStyleBackColor = true;
            btnAlbumGetir.Click += btnAlbumGetir_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(441, 18);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(127, 61);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(441, 85);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(127, 61);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // Sil
            // 
            Sil.Location = new Point(441, 152);
            Sil.Name = "Sil";
            Sil.Size = new Size(127, 61);
            Sil.TabIndex = 8;
            Sil.Text = "Sil";
            Sil.UseVisualStyleBackColor = true;
            Sil.Click += Sil_Click;
            // 
            // txtAlbumAdi
            // 
            txtAlbumAdi.Location = new Point(162, 18);
            txtAlbumAdi.Name = "txtAlbumAdi";
            txtAlbumAdi.Size = new Size(250, 27);
            txtAlbumAdi.TabIndex = 9;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(162, 139);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(250, 27);
            txtFiyat.TabIndex = 10;
            // 
            // txtSanatci
            // 
            txtSanatci.Location = new Point(162, 61);
            txtSanatci.Name = "txtSanatci";
            txtSanatci.Size = new Size(250, 27);
            txtSanatci.TabIndex = 12;
            // 
            // txtIndirimOrani
            // 
            txtIndirimOrani.Location = new Point(162, 183);
            txtIndirimOrani.Name = "txtIndirimOrani";
            txtIndirimOrani.Size = new Size(250, 27);
            txtIndirimOrani.TabIndex = 13;
            // 
            // dpCikisTarihi
            // 
            dpCikisTarihi.Location = new Point(162, 100);
            dpCikisTarihi.Name = "dpCikisTarihi";
            dpCikisTarihi.Size = new Size(250, 27);
            dpCikisTarihi.TabIndex = 14;
            // 
            // cbSatisDevamMi
            // 
            cbSatisDevamMi.AutoSize = true;
            cbSatisDevamMi.Location = new Point(162, 229);
            cbSatisDevamMi.Name = "cbSatisDevamMi";
            cbSatisDevamMi.Size = new Size(141, 24);
            cbSatisDevamMi.TabIndex = 15;
            cbSatisDevamMi.Text = "Satış Devam Mı?";
            cbSatisDevamMi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 16;
            label1.Text = "Albüm Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 17;
            label2.Text = "Sanatçı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 186);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 18;
            label3.Text = "İndirim Oranı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 19;
            label4.Text = "Fiyat:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 105);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 20;
            label5.Text = "Çıkış Tarihi:";
            // 
            // lst_liste
            // 
            lst_liste.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3 });
            lst_liste.FullRowSelect = true;
            lst_liste.GridLines = true;
            lst_liste.Location = new Point(12, 417);
            lst_liste.Name = "lst_liste";
            lst_liste.Size = new Size(829, 190);
            lst_liste.TabIndex = 21;
            lst_liste.UseCompatibleStateImageBehavior = false;
            lst_liste.View = View.Details;
            lst_liste.SelectedIndexChanged += lst_liste_SelectedIndexChanged;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "AlbumAdı";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Sanatçı";
            columnHeader3.Width = 200;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 619);
            Controls.Add(lst_liste);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbSatisDevamMi);
            Controls.Add(dpCikisTarihi);
            Controls.Add(txtIndirimOrani);
            Controls.Add(txtSanatci);
            Controls.Add(txtFiyat);
            Controls.Add(txtAlbumAdi);
            Controls.Add(Sil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(btnAlbumGetir);
            Controls.Add(btnIndirimdekiAlbumler);
            Controls.Add(btnEklenenSonOn);
            Controls.Add(btnSatisDevam);
            Controls.Add(btnSatisDurmus);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSatisDurmus;
        private Button btnSatisDevam;
        private Button btnEklenenSonOn;
        private Button btnIndirimdekiAlbumler;
        private Button btnAlbumGetir;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button Sil;
        private TextBox txtAlbumAdi;
        private TextBox txtFiyat;
        private TextBox txtSanatci;
        private TextBox txtIndirimOrani;
        private DateTimePicker dpCikisTarihi;
        private CheckBox cbSatisDevamMi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListView lst_liste;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}