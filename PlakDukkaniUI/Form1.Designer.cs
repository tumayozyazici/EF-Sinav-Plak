namespace PlakDukkaniUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGirisYap = new Button();
            txtGirisKullaniciAdi = new TextBox();
            txtGirisSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDogrulamaSifre = new TextBox();
            txtKayitSifre = new TextBox();
            txtKayitKullaniciAdi = new TextBox();
            label5 = new Label();
            btnKayitOl = new Button();
            SuspendLayout();
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(202, 120);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(94, 29);
            btnGirisYap.TabIndex = 0;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // txtGirisKullaniciAdi
            // 
            txtGirisKullaniciAdi.Location = new Point(188, 54);
            txtGirisKullaniciAdi.Name = "txtGirisKullaniciAdi";
            txtGirisKullaniciAdi.Size = new Size(125, 27);
            txtGirisKullaniciAdi.TabIndex = 1;
            // 
            // txtGirisSifre
            // 
            txtGirisSifre.Location = new Point(188, 87);
            txtGirisSifre.Name = "txtGirisSifre";
            txtGirisSifre.Size = new Size(125, 27);
            txtGirisSifre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 54);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 87);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 4;
            label2.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 84);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 8;
            label3.Text = "Şifre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(419, 54);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 7;
            label4.Text = "Kullanıcı Adı:";
            // 
            // txtDogrulamaSifre
            // 
            txtDogrulamaSifre.Location = new Point(573, 117);
            txtDogrulamaSifre.Name = "txtDogrulamaSifre";
            txtDogrulamaSifre.Size = new Size(125, 27);
            txtDogrulamaSifre.TabIndex = 6;
            // 
            // txtKayitSifre
            // 
            txtKayitSifre.Location = new Point(573, 84);
            txtKayitSifre.Name = "txtKayitSifre";
            txtKayitSifre.Size = new Size(125, 27);
            txtKayitSifre.TabIndex = 5;
            // 
            // txtKayitKullaniciAdi
            // 
            txtKayitKullaniciAdi.Location = new Point(573, 51);
            txtKayitKullaniciAdi.Name = "txtKayitKullaniciAdi";
            txtKayitKullaniciAdi.Size = new Size(125, 27);
            txtKayitKullaniciAdi.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(403, 120);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 10;
            label5.Text = "Şifreyi Doğrula:";
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(588, 150);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(94, 29);
            btnKayitOl.TabIndex = 11;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 251);
            Controls.Add(btnKayitOl);
            Controls.Add(label5);
            Controls.Add(txtKayitKullaniciAdi);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtDogrulamaSifre);
            Controls.Add(txtKayitSifre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtGirisSifre);
            Controls.Add(txtGirisKullaniciAdi);
            Controls.Add(btnGirisYap);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGirisYap;
        private TextBox txtGirisKullaniciAdi;
        private TextBox txtGirisSifre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDogrulamaSifre;
        private TextBox txtKayitSifre;
        private TextBox txtKayitKullaniciAdi;
        private Label label5;
        private Button btnKayitOl;
    }
}
