namespace SOHATS
{
    partial class HastaIslemleriForm
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
            this.lblDosyaNo = new System.Windows.Forms.Label();
            this.txtDosyaNo = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.lblHastaAdi = new System.Windows.Forms.Label();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.lblKurumAdi = new System.Windows.Forms.Label();
            this.txtKurumAdi = new System.Windows.Forms.TextBox();
            this.btnHastaBilgileri = new System.Windows.Forms.Button();
            this.lblSevkTarihi = new System.Windows.Forms.Label();
            this.dtpSevkTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblOncekiIslemler = new System.Windows.Forms.Label();
            this.cmbOncekiIslemler = new System.Windows.Forms.ComboBox();
            this.btnGit = new System.Windows.Forms.Button();
            this.lblPoliklinik = new System.Windows.Forms.Label();
            this.cmbPoliklinik = new System.Windows.Forms.ComboBox();
            this.lblSiraNo = new System.Windows.Forms.Label();
            this.txtSiraNo = new System.Windows.Forms.TextBox();
            this.lblYapilanIslem = new System.Windows.Forms.Label();
            this.txtYapilanIslem = new System.Windows.Forms.TextBox();
            this.lblDrKodu = new System.Windows.Forms.Label();
            this.cmbDrKodu = new System.Windows.Forms.ComboBox();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.numMiktar = new System.Windows.Forms.NumericUpDown();
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.numBirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.grpYapilanIslemler = new System.Windows.Forms.GroupBox();
            this.dgvIslemler = new System.Windows.Forms.DataGridView();
            this.lblToplamTutarLabel = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnSecSil = new System.Windows.Forms.Button();
            this.btnTaburcu = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnBaskiOnizleme = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBirimFiyat)).BeginInit();
            this.grpYapilanIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDosyaNo
            // 
            this.lblDosyaNo.AutoSize = true;
            this.lblDosyaNo.Location = new System.Drawing.Point(10, 13);
            this.lblDosyaNo.Name = "lblDosyaNo";
            this.lblDosyaNo.Size = new System.Drawing.Size(54, 15);
            this.lblDosyaNo.TabIndex = 0;
            this.lblDosyaNo.Text = "Dosya No";
            // 
            // txtDosyaNo
            // 
            this.txtDosyaNo.Location = new System.Drawing.Point(70, 10);
            this.txtDosyaNo.Name = "txtDosyaNo";
            this.txtDosyaNo.Size = new System.Drawing.Size(80, 23);
            this.txtDosyaNo.TabIndex = 1;
            this.txtDosyaNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDosyaNo_KeyDown);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(155, 9);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(45, 24);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.BtnBul_Click);
            // 
            // lblHastaAdi
            // 
            this.lblHastaAdi.AutoSize = true;
            this.lblHastaAdi.Location = new System.Drawing.Point(210, 13);
            this.lblHastaAdi.Name = "lblHastaAdi";
            this.lblHastaAdi.Size = new System.Drawing.Size(55, 15);
            this.lblHastaAdi.TabIndex = 3;
            this.lblHastaAdi.Text = "Hasta Adı";
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Location = new System.Drawing.Point(270, 10);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.ReadOnly = true;
            this.txtHastaAdi.Size = new System.Drawing.Size(100, 23);
            this.txtHastaAdi.TabIndex = 4;
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Location = new System.Drawing.Point(380, 13);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(42, 15);
            this.lblSoyadi.TabIndex = 5;
            this.lblSoyadi.Text = "Soyadı";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(430, 10);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.ReadOnly = true;
            this.txtSoyadi.Size = new System.Drawing.Size(100, 23);
            this.txtSoyadi.TabIndex = 6;
            // 
            // lblKurumAdi
            // 
            this.lblKurumAdi.AutoSize = true;
            this.lblKurumAdi.Location = new System.Drawing.Point(540, 13);
            this.lblKurumAdi.Name = "lblKurumAdi";
            this.lblKurumAdi.Size = new System.Drawing.Size(62, 15);
            this.lblKurumAdi.TabIndex = 7;
            this.lblKurumAdi.Text = "Kurum Adı";
            // 
            // txtKurumAdi
            // 
            this.txtKurumAdi.Location = new System.Drawing.Point(610, 10);
            this.txtKurumAdi.Name = "txtKurumAdi";
            this.txtKurumAdi.ReadOnly = true;
            this.txtKurumAdi.Size = new System.Drawing.Size(120, 23);
            this.txtKurumAdi.TabIndex = 8;
            // 
            // btnHastaBilgileri
            // 
            this.btnHastaBilgileri.Location = new System.Drawing.Point(750, 9);
            this.btnHastaBilgileri.Name = "btnHastaBilgileri";
            this.btnHastaBilgileri.Size = new System.Drawing.Size(100, 24);
            this.btnHastaBilgileri.TabIndex = 9;
            this.btnHastaBilgileri.Text = "Hasta Bilgileri";
            this.btnHastaBilgileri.UseVisualStyleBackColor = true;
            this.btnHastaBilgileri.Click += new System.EventHandler(this.BtnHastaBilgileri_Click);
            // 
            // lblSevkTarihi
            // 
            this.lblSevkTarihi.AutoSize = true;
            this.lblSevkTarihi.Location = new System.Drawing.Point(10, 48);
            this.lblSevkTarihi.Name = "lblSevkTarihi";
            this.lblSevkTarihi.Size = new System.Drawing.Size(64, 15);
            this.lblSevkTarihi.TabIndex = 10;
            this.lblSevkTarihi.Text = "Sevk Tarihi";
            // 
            // dtpSevkTarihi
            // 
            this.dtpSevkTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSevkTarihi.Location = new System.Drawing.Point(80, 45);
            this.dtpSevkTarihi.Name = "dtpSevkTarihi";
            this.dtpSevkTarihi.Size = new System.Drawing.Size(100, 23);
            this.dtpSevkTarihi.TabIndex = 11;
            // 
            // lblOncekiIslemler
            // 
            this.lblOncekiIslemler.AutoSize = true;
            this.lblOncekiIslemler.Location = new System.Drawing.Point(200, 48);
            this.lblOncekiIslemler.Name = "lblOncekiIslemler";
            this.lblOncekiIslemler.Size = new System.Drawing.Size(85, 15);
            this.lblOncekiIslemler.TabIndex = 12;
            this.lblOncekiIslemler.Text = "Önceki İşlemler";
            // 
            // cmbOncekiIslemler
            // 
            this.cmbOncekiIslemler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOncekiIslemler.FormattingEnabled = true;
            this.cmbOncekiIslemler.Location = new System.Drawing.Point(290, 45);
            this.cmbOncekiIslemler.Name = "cmbOncekiIslemler";
            this.cmbOncekiIslemler.Size = new System.Drawing.Size(150, 23);
            this.cmbOncekiIslemler.TabIndex = 13;
            // 
            // btnGit
            // 
            this.btnGit.Location = new System.Drawing.Point(450, 44);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(45, 24);
            this.btnGit.TabIndex = 14;
            this.btnGit.Text = "Git";
            this.btnGit.UseVisualStyleBackColor = true;
            this.btnGit.Click += new System.EventHandler(this.BtnGit_Click);
            // 
            // lblPoliklinik
            // 
            this.lblPoliklinik.AutoSize = true;
            this.lblPoliklinik.Location = new System.Drawing.Point(10, 83);
            this.lblPoliklinik.Name = "lblPoliklinik";
            this.lblPoliklinik.Size = new System.Drawing.Size(54, 15);
            this.lblPoliklinik.TabIndex = 15;
            this.lblPoliklinik.Text = "Poliklinik";
            // 
            // cmbPoliklinik
            // 
            this.cmbPoliklinik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPoliklinik.FormattingEnabled = true;
            this.cmbPoliklinik.Location = new System.Drawing.Point(70, 80);
            this.cmbPoliklinik.Name = "cmbPoliklinik";
            this.cmbPoliklinik.Size = new System.Drawing.Size(100, 23);
            this.cmbPoliklinik.TabIndex = 16;
            // 
            // lblSiraNo
            // 
            this.lblSiraNo.AutoSize = true;
            this.lblSiraNo.Location = new System.Drawing.Point(180, 83);
            this.lblSiraNo.Name = "lblSiraNo";
            this.lblSiraNo.Size = new System.Drawing.Size(49, 15);
            this.lblSiraNo.TabIndex = 17;
            this.lblSiraNo.Text = "SIRA NO";
            // 
            // txtSiraNo
            // 
            this.txtSiraNo.Location = new System.Drawing.Point(235, 80);
            this.txtSiraNo.Name = "txtSiraNo";
            this.txtSiraNo.ReadOnly = true;
            this.txtSiraNo.Size = new System.Drawing.Size(40, 23);
            this.txtSiraNo.TabIndex = 18;
            // 
            // lblYapilanIslem
            // 
            this.lblYapilanIslem.AutoSize = true;
            this.lblYapilanIslem.Location = new System.Drawing.Point(285, 83);
            this.lblYapilanIslem.Name = "lblYapilanIslem";
            this.lblYapilanIslem.Size = new System.Drawing.Size(75, 15);
            this.lblYapilanIslem.TabIndex = 19;
            this.lblYapilanIslem.Text = "Yapılan İşlem";
            // 
            // txtYapilanIslem
            // 
            this.txtYapilanIslem.Location = new System.Drawing.Point(365, 80);
            this.txtYapilanIslem.Name = "txtYapilanIslem";
            this.txtYapilanIslem.Size = new System.Drawing.Size(120, 23);
            this.txtYapilanIslem.TabIndex = 20;
            // 
            // lblDrKodu
            // 
            this.lblDrKodu.AutoSize = true;
            this.lblDrKodu.Location = new System.Drawing.Point(495, 83);
            this.lblDrKodu.Name = "lblDrKodu";
            this.lblDrKodu.Size = new System.Drawing.Size(50, 15);
            this.lblDrKodu.TabIndex = 21;
            this.lblDrKodu.Text = "Dr. Kodu";
            // 
            // cmbDrKodu
            // 
            this.cmbDrKodu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrKodu.FormattingEnabled = true;
            this.cmbDrKodu.Location = new System.Drawing.Point(550, 80);
            this.cmbDrKodu.Name = "cmbDrKodu";
            this.cmbDrKodu.Size = new System.Drawing.Size(80, 23);
            this.cmbDrKodu.TabIndex = 22;
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(640, 83);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(40, 15);
            this.lblMiktar.TabIndex = 23;
            this.lblMiktar.Text = "Miktar";
            // 
            // numMiktar
            // 
            this.numMiktar.Location = new System.Drawing.Point(685, 80);
            this.numMiktar.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numMiktar.Name = "numMiktar";
            this.numMiktar.Size = new System.Drawing.Size(50, 23);
            this.numMiktar.TabIndex = 24;
            this.numMiktar.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Location = new System.Drawing.Point(745, 83);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(60, 15);
            this.lblBirimFiyat.TabIndex = 25;
            this.lblBirimFiyat.Text = "Birim Fiyat";
            // 
            // numBirimFiyat
            // 
            this.numBirimFiyat.DecimalPlaces = 2;
            this.numBirimFiyat.Location = new System.Drawing.Point(810, 80);
            this.numBirimFiyat.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            this.numBirimFiyat.Name = "numBirimFiyat";
            this.numBirimFiyat.Size = new System.Drawing.Size(70, 23);
            this.numBirimFiyat.TabIndex = 26;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(810, 110);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(70, 25);
            this.btnEkle.TabIndex = 27;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // grpYapilanIslemler
            // 
            this.grpYapilanIslemler.Controls.Add(this.dgvIslemler);
            this.grpYapilanIslemler.Location = new System.Drawing.Point(10, 145);
            this.grpYapilanIslemler.Name = "grpYapilanIslemler";
            this.grpYapilanIslemler.Size = new System.Drawing.Size(865, 350);
            this.grpYapilanIslemler.TabIndex = 28;
            this.grpYapilanIslemler.TabStop = false;
            this.grpYapilanIslemler.Text = "Yapılan Tahlil ve İşlemler";
            // 
            // dgvIslemler
            // 
            this.dgvIslemler.AllowUserToAddRows = false;
            this.dgvIslemler.AllowUserToDeleteRows = false;
            this.dgvIslemler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIslemler.Location = new System.Drawing.Point(5, 20);
            this.dgvIslemler.Name = "dgvIslemler";
            this.dgvIslemler.ReadOnly = true;
            this.dgvIslemler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIslemler.Size = new System.Drawing.Size(855, 320);
            this.dgvIslemler.TabIndex = 0;
            this.dgvIslemler.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvIslemler_DataError);
            // 
            // lblToplamTutarLabel
            // 
            this.lblToplamTutarLabel.AutoSize = true;
            this.lblToplamTutarLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblToplamTutarLabel.Location = new System.Drawing.Point(650, 505);
            this.lblToplamTutarLabel.Name = "lblToplamTutarLabel";
            this.lblToplamTutarLabel.Size = new System.Drawing.Size(107, 20);
            this.lblToplamTutarLabel.TabIndex = 29;
            this.lblToplamTutarLabel.Text = "Toplam Tutar :";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblToplamTutar.ForeColor = System.Drawing.Color.Red;
            this.lblToplamTutar.Location = new System.Drawing.Point(770, 505);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(100, 25);
            this.lblToplamTutar.TabIndex = 30;
            this.lblToplamTutar.Text = "0,00";
            this.lblToplamTutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(10, 545);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(80, 30);
            this.btnYeni.TabIndex = 31;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.BtnYeni_Click);
            // 
            // btnSecSil
            // 
            this.btnSecSil.Location = new System.Drawing.Point(95, 545);
            this.btnSecSil.Name = "btnSecSil";
            this.btnSecSil.Size = new System.Drawing.Size(80, 30);
            this.btnSecSil.TabIndex = 32;
            this.btnSecSil.Text = "Seç - Sil";
            this.btnSecSil.UseVisualStyleBackColor = true;
            this.btnSecSil.Click += new System.EventHandler(this.BtnSecSil_Click);
            // 
            // btnTaburcu
            // 
            this.btnTaburcu.Location = new System.Drawing.Point(180, 545);
            this.btnTaburcu.Name = "btnTaburcu";
            this.btnTaburcu.Size = new System.Drawing.Size(80, 30);
            this.btnTaburcu.TabIndex = 33;
            this.btnTaburcu.Text = "Taburcu";
            this.btnTaburcu.UseVisualStyleBackColor = true;
            this.btnTaburcu.Click += new System.EventHandler(this.BtnTaburcu_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(265, 545);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(80, 30);
            this.btnYazdir.TabIndex = 34;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // btnBaskiOnizleme
            // 
            this.btnBaskiOnizleme.Location = new System.Drawing.Point(350, 545);
            this.btnBaskiOnizleme.Name = "btnBaskiOnizleme";
            this.btnBaskiOnizleme.Size = new System.Drawing.Size(100, 30);
            this.btnBaskiOnizleme.TabIndex = 35;
            this.btnBaskiOnizleme.Text = "Baskı Önizleme";
            this.btnBaskiOnizleme.UseVisualStyleBackColor = true;
            this.btnBaskiOnizleme.Click += new System.EventHandler(this.BtnBaskiOnizleme_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(800, 545);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(80, 30);
            this.btnCikis.TabIndex = 36;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // HastaIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnBaskiOnizleme);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnTaburcu);
            this.Controls.Add(this.btnSecSil);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.lblToplamTutarLabel);
            this.Controls.Add(this.grpYapilanIslemler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.numBirimFiyat);
            this.Controls.Add(this.lblBirimFiyat);
            this.Controls.Add(this.numMiktar);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.cmbDrKodu);
            this.Controls.Add(this.lblDrKodu);
            this.Controls.Add(this.txtYapilanIslem);
            this.Controls.Add(this.lblYapilanIslem);
            this.Controls.Add(this.txtSiraNo);
            this.Controls.Add(this.lblSiraNo);
            this.Controls.Add(this.cmbPoliklinik);
            this.Controls.Add(this.lblPoliklinik);
            this.Controls.Add(this.btnGit);
            this.Controls.Add(this.cmbOncekiIslemler);
            this.Controls.Add(this.lblOncekiIslemler);
            this.Controls.Add(this.dtpSevkTarihi);
            this.Controls.Add(this.lblSevkTarihi);
            this.Controls.Add(this.btnHastaBilgileri);
            this.Controls.Add(this.txtKurumAdi);
            this.Controls.Add(this.lblKurumAdi);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.txtHastaAdi);
            this.Controls.Add(this.lblHastaAdi);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtDosyaNo);
            this.Controls.Add(this.lblDosyaNo);
            this.Name = "HastaIslemleriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hasta İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.numMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBirimFiyat)).EndInit();
            this.grpYapilanIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDosyaNo;
        private System.Windows.Forms.TextBox txtDosyaNo;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label lblHastaAdi;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label lblKurumAdi;
        private System.Windows.Forms.TextBox txtKurumAdi;
        private System.Windows.Forms.Button btnHastaBilgileri;
        private System.Windows.Forms.Label lblSevkTarihi;
        private System.Windows.Forms.DateTimePicker dtpSevkTarihi;
        private System.Windows.Forms.Label lblOncekiIslemler;
        private System.Windows.Forms.ComboBox cmbOncekiIslemler;
        private System.Windows.Forms.Button btnGit;
        private System.Windows.Forms.Label lblPoliklinik;
        private System.Windows.Forms.ComboBox cmbPoliklinik;
        private System.Windows.Forms.Label lblSiraNo;
        private System.Windows.Forms.TextBox txtSiraNo;
        private System.Windows.Forms.Label lblYapilanIslem;
        private System.Windows.Forms.TextBox txtYapilanIslem;
        private System.Windows.Forms.Label lblDrKodu;
        private System.Windows.Forms.ComboBox cmbDrKodu;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.NumericUpDown numMiktar;
        private System.Windows.Forms.Label lblBirimFiyat;
        private System.Windows.Forms.NumericUpDown numBirimFiyat;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox grpYapilanIslemler;
        private System.Windows.Forms.DataGridView dgvIslemler;
        private System.Windows.Forms.Label lblToplamTutarLabel;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSecSil;
        private System.Windows.Forms.Button btnTaburcu;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnBaskiOnizleme;
        private System.Windows.Forms.Button btnCikis;
    }
}
