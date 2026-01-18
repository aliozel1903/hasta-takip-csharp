namespace SOHATS
{
    partial class KullaniciIslemleriForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblKullaniciKodu = new System.Windows.Forms.Label();
            this.cmbKullaniciKodu = new System.Windows.Forms.ComboBox();
            this.btnYeniKullaniciEkle = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblYetki = new System.Windows.Forms.Label();
            this.cmbYetki = new System.Windows.Forms.ComboBox();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKullaniciKodu
            // 
            this.lblKullaniciKodu.AutoSize = true;
            this.lblKullaniciKodu.Location = new System.Drawing.Point(20, 23);
            this.lblKullaniciKodu.Name = "lblKullaniciKodu";
            this.lblKullaniciKodu.Size = new System.Drawing.Size(85, 15);
            this.lblKullaniciKodu.TabIndex = 0;
            this.lblKullaniciKodu.Text = "Kullanıcı Kodu";
            // 
            // cmbKullaniciKodu
            // 
            this.cmbKullaniciKodu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKullaniciKodu.FormattingEnabled = true;
            this.cmbKullaniciKodu.Location = new System.Drawing.Point(120, 20);
            this.cmbKullaniciKodu.Name = "cmbKullaniciKodu";
            this.cmbKullaniciKodu.Size = new System.Drawing.Size(150, 23);
            this.cmbKullaniciKodu.TabIndex = 1;
            this.cmbKullaniciKodu.SelectedIndexChanged += new System.EventHandler(this.CmbKullaniciKodu_SelectedIndexChanged);
            // 
            // btnYeniKullaniciEkle
            // 
            this.btnYeniKullaniciEkle.Location = new System.Drawing.Point(120, 55);
            this.btnYeniKullaniciEkle.Name = "btnYeniKullaniciEkle";
            this.btnYeniKullaniciEkle.Size = new System.Drawing.Size(150, 25);
            this.btnYeniKullaniciEkle.TabIndex = 2;
            this.btnYeniKullaniciEkle.Text = "Yeni Kullanıcı Ekle";
            this.btnYeniKullaniciEkle.UseVisualStyleBackColor = true;
            this.btnYeniKullaniciEkle.Click += new System.EventHandler(this.BtnYeniKullaniciEkle_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(20, 98);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(21, 15);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(120, 95);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 23);
            this.txtAd.TabIndex = 4;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(20, 128);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(40, 15);
            this.lblSoyad.TabIndex = 5;
            this.lblSoyad.Text = "Soyad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(120, 125);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 23);
            this.txtSoyad.TabIndex = 6;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(20, 158);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(30, 15);
            this.lblSifre.TabIndex = 7;
            this.lblSifre.Text = "Şifre";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(120, 155);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(200, 23);
            this.txtSifre.TabIndex = 8;
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Location = new System.Drawing.Point(20, 188);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(32, 15);
            this.lblYetki.TabIndex = 9;
            this.lblYetki.Text = "Yetki";
            // 
            // cmbYetki
            // 
            this.cmbYetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYetki.FormattingEnabled = true;
            this.cmbYetki.Items.AddRange(new object[] { "Yonetici", "Personel" });
            this.cmbYetki.Location = new System.Drawing.Point(120, 185);
            this.cmbYetki.Name = "cmbYetki";
            this.cmbYetki.Size = new System.Drawing.Size(150, 23);
            this.cmbYetki.TabIndex = 10;
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Checked = true;
            this.chkAktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAktif.Location = new System.Drawing.Point(120, 218);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(49, 19);
            this.chkAktif.TabIndex = 11;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(20, 258);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(70, 28);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(100, 258);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(70, 28);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(180, 258);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(70, 28);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(300, 258);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(70, 28);
            this.btnKapat.TabIndex = 15;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // KullaniciIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.chkAktif);
            this.Controls.Add(this.cmbYetki);
            this.Controls.Add(this.lblYetki);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnYeniKullaniciEkle);
            this.Controls.Add(this.cmbKullaniciKodu);
            this.Controls.Add(this.lblKullaniciKodu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "KullaniciIslemleriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SOHATS - Kullanıcı Tanıtma";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblKullaniciKodu;
        private System.Windows.Forms.ComboBox cmbKullaniciKodu;
        private System.Windows.Forms.Button btnYeniKullaniciEkle;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblYetki;
        private System.Windows.Forms.ComboBox cmbYetki;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
    }
}
