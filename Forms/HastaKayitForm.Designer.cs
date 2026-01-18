namespace SOHATS
{
    partial class HastaKayitForm
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
            this.lblDosyaNo = new System.Windows.Forms.Label();
            this.txtDosyaNo = new System.Windows.Forms.TextBox();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblDogumYeri = new System.Windows.Forms.Label();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblBabaAdi = new System.Windows.Forms.Label();
            this.txtBabaAdi = new System.Windows.Forms.TextBox();
            this.lblAnaAdi = new System.Windows.Forms.Label();
            this.txtAnaAdi = new System.Windows.Forms.TextBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.lblKurumAdi = new System.Windows.Forms.Label();
            this.txtKurumAdi = new System.Windows.Forms.TextBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDosyaNo
            // 
            this.lblDosyaNo.AutoSize = true;
            this.lblDosyaNo.Location = new System.Drawing.Point(20, 23);
            this.lblDosyaNo.Name = "lblDosyaNo";
            this.lblDosyaNo.Size = new System.Drawing.Size(54, 15);
            this.lblDosyaNo.TabIndex = 0;
            this.lblDosyaNo.Text = "Dosya No";
            // 
            // txtDosyaNo
            // 
            this.txtDosyaNo.Location = new System.Drawing.Point(130, 20);
            this.txtDosyaNo.Name = "txtDosyaNo";
            this.txtDosyaNo.Size = new System.Drawing.Size(150, 23);
            this.txtDosyaNo.TabIndex = 1;
            this.txtDosyaNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDosyaNo_KeyDown);
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Location = new System.Drawing.Point(20, 53);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(74, 15);
            this.lblTCNo.TabIndex = 2;
            this.lblTCNo.Text = "TC Kimlik No";
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(130, 50);
            this.txtTCNo.MaxLength = 11;
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(150, 23);
            this.txtTCNo.TabIndex = 3;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(20, 83);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(21, 15);
            this.lblAd.TabIndex = 4;
            this.lblAd.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(130, 80);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 23);
            this.txtAd.TabIndex = 5;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(20, 113);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(40, 15);
            this.lblSoyad.TabIndex = 6;
            this.lblSoyad.Text = "Soyad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(130, 110);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 23);
            this.txtSoyad.TabIndex = 7;
            // 
            // lblDogumYeri
            // 
            this.lblDogumYeri.AutoSize = true;
            this.lblDogumYeri.Location = new System.Drawing.Point(20, 143);
            this.lblDogumYeri.Name = "lblDogumYeri";
            this.lblDogumYeri.Size = new System.Drawing.Size(71, 15);
            this.lblDogumYeri.TabIndex = 8;
            this.lblDogumYeri.Text = "Doğum Yeri";
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(130, 140);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(200, 23);
            this.txtDogumYeri.TabIndex = 9;
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(20, 173);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(80, 15);
            this.lblDogumTarihi.TabIndex = 10;
            this.lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(130, 170);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(120, 23);
            this.dtpDogumTarihi.TabIndex = 11;
            // 
            // lblBabaAdi
            // 
            this.lblBabaAdi.AutoSize = true;
            this.lblBabaAdi.Location = new System.Drawing.Point(20, 203);
            this.lblBabaAdi.Name = "lblBabaAdi";
            this.lblBabaAdi.Size = new System.Drawing.Size(52, 15);
            this.lblBabaAdi.TabIndex = 12;
            this.lblBabaAdi.Text = "Baba Adı";
            // 
            // txtBabaAdi
            // 
            this.txtBabaAdi.Location = new System.Drawing.Point(130, 200);
            this.txtBabaAdi.Name = "txtBabaAdi";
            this.txtBabaAdi.Size = new System.Drawing.Size(150, 23);
            this.txtBabaAdi.TabIndex = 13;
            // 
            // lblAnaAdi
            // 
            this.lblAnaAdi.AutoSize = true;
            this.lblAnaAdi.Location = new System.Drawing.Point(20, 233);
            this.lblAnaAdi.Name = "lblAnaAdi";
            this.lblAnaAdi.Size = new System.Drawing.Size(47, 15);
            this.lblAnaAdi.TabIndex = 14;
            this.lblAnaAdi.Text = "Ana Adı";
            // 
            // txtAnaAdi
            // 
            this.txtAnaAdi.Location = new System.Drawing.Point(130, 230);
            this.txtAnaAdi.Name = "txtAnaAdi";
            this.txtAnaAdi.Size = new System.Drawing.Size(150, 23);
            this.txtAnaAdi.TabIndex = 15;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(20, 263);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(48, 15);
            this.lblCinsiyet.TabIndex = 16;
            this.lblCinsiyet.Text = "Cinsiyet";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            this.cmbCinsiyet.Location = new System.Drawing.Point(130, 260);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(100, 23);
            this.cmbCinsiyet.TabIndex = 17;
            // 
            // lblKurumAdi
            // 
            this.lblKurumAdi.AutoSize = true;
            this.lblKurumAdi.Location = new System.Drawing.Point(20, 293);
            this.lblKurumAdi.Name = "lblKurumAdi";
            this.lblKurumAdi.Size = new System.Drawing.Size(62, 15);
            this.lblKurumAdi.TabIndex = 18;
            this.lblKurumAdi.Text = "Kurum Adı";
            // 
            // txtKurumAdi
            // 
            this.txtKurumAdi.Location = new System.Drawing.Point(130, 290);
            this.txtKurumAdi.Name = "txtKurumAdi";
            this.txtKurumAdi.Size = new System.Drawing.Size(250, 23);
            this.txtKurumAdi.TabIndex = 19;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(20, 335);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(70, 28);
            this.btnYeni.TabIndex = 20;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.BtnYeni_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(100, 335);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(70, 28);
            this.btnKaydet.TabIndex = 21;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(180, 335);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(70, 28);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(260, 335);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(70, 28);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(400, 335);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(70, 28);
            this.btnKapat.TabIndex = 24;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // HastaKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.txtKurumAdi);
            this.Controls.Add(this.lblKurumAdi);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.txtAnaAdi);
            this.Controls.Add(this.lblAnaAdi);
            this.Controls.Add(this.txtBabaAdi);
            this.Controls.Add(this.lblBabaAdi);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.txtDogumYeri);
            this.Controls.Add(this.lblDogumYeri);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtTCNo);
            this.Controls.Add(this.lblTCNo);
            this.Controls.Add(this.txtDosyaNo);
            this.Controls.Add(this.lblDosyaNo);
            this.Name = "HastaKayitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SOHATS - Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDosyaNo;
        private System.Windows.Forms.TextBox txtDosyaNo;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblDogumYeri;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label lblBabaAdi;
        private System.Windows.Forms.TextBox txtBabaAdi;
        private System.Windows.Forms.Label lblAnaAdi;
        private System.Windows.Forms.TextBox txtAnaAdi;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label lblKurumAdi;
        private System.Windows.Forms.TextBox txtKurumAdi;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
    }
}
