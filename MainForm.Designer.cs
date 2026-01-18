namespace SOHATS
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dosyaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.oturumuKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referanslarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikTanimlariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorTanimlariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKabulMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniHastaKayitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaAramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaRaporlariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pencereMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.basamakliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yatayDoseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dikeyDoseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simgeleriDuzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblKullaniciBilgi = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaMenu,
            this.referanslarMenu,
            this.hastaKabulMenu,
            this.raporlarMenu,
            this.pencereMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.pencereMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // dosyaMenu
            // 
            this.dosyaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oturumuKapatToolStripMenuItem,
            this.toolStripSeparator1,
            this.cikisToolStripMenuItem});
            this.dosyaMenu.Name = "dosyaMenu";
            this.dosyaMenu.Size = new System.Drawing.Size(51, 20);
            this.dosyaMenu.Text = "Dosya";
            // 
            // oturumuKapatToolStripMenuItem
            // 
            this.oturumuKapatToolStripMenuItem.Name = "oturumuKapatToolStripMenuItem";
            this.oturumuKapatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oturumuKapatToolStripMenuItem.Text = "Oturumu Kapat";
            this.oturumuKapatToolStripMenuItem.Click += new System.EventHandler(this.OturumuKapat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // referanslarMenu
            // 
            this.referanslarMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullaniciIslemleriToolStripMenuItem,
            this.poliklinikTanimlariToolStripMenuItem,
            this.doktorTanimlariToolStripMenuItem});
            this.referanslarMenu.Name = "referanslarMenu";
            this.referanslarMenu.Size = new System.Drawing.Size(76, 20);
            this.referanslarMenu.Text = "Referanslar";
            // 
            // kullaniciIslemleriToolStripMenuItem
            // 
            this.kullaniciIslemleriToolStripMenuItem.Name = "kullaniciIslemleriToolStripMenuItem";
            this.kullaniciIslemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kullaniciIslemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            this.kullaniciIslemleriToolStripMenuItem.Click += new System.EventHandler(this.KullaniciIslemleri_Click);
            // 
            // poliklinikTanimlariToolStripMenuItem
            // 
            this.poliklinikTanimlariToolStripMenuItem.Name = "poliklinikTanimlariToolStripMenuItem";
            this.poliklinikTanimlariToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poliklinikTanimlariToolStripMenuItem.Text = "Poliklinik Tanımları";
            this.poliklinikTanimlariToolStripMenuItem.Click += new System.EventHandler(this.PoliklinikTanimlari_Click);
            // 
            // doktorTanimlariToolStripMenuItem
            // 
            this.doktorTanimlariToolStripMenuItem.Name = "doktorTanimlariToolStripMenuItem";
            this.doktorTanimlariToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doktorTanimlariToolStripMenuItem.Text = "Doktor Tanımları";
            this.doktorTanimlariToolStripMenuItem.Click += new System.EventHandler(this.DoktorTanimlari_Click);
            // 
            // hastaKabulMenu
            // 
            this.hastaKabulMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaIslemleriToolStripMenuItem,
            this.yeniHastaKayitToolStripMenuItem,
            this.hastaAramaToolStripMenuItem});
            this.hastaKabulMenu.Name = "hastaKabulMenu";
            this.hastaKabulMenu.Size = new System.Drawing.Size(80, 20);
            this.hastaKabulMenu.Text = "Hasta Kabul";
            // 
            // hastaIslemleriToolStripMenuItem
            // 
            this.hastaIslemleriToolStripMenuItem.Name = "hastaIslemleriToolStripMenuItem";
            this.hastaIslemleriToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.hastaIslemleriToolStripMenuItem.Text = "Hasta İşlemleri";
            this.hastaIslemleriToolStripMenuItem.Click += new System.EventHandler(this.HastaIslemleri_Click);
            // 
            // yeniHastaKayitToolStripMenuItem
            // 
            this.yeniHastaKayitToolStripMenuItem.Name = "yeniHastaKayitToolStripMenuItem";
            this.yeniHastaKayitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.yeniHastaKayitToolStripMenuItem.Text = "Yeni Hasta Kayıt";
            this.yeniHastaKayitToolStripMenuItem.Click += new System.EventHandler(this.YeniHastaKayit_Click);
            // 
            // hastaAramaToolStripMenuItem
            // 
            this.hastaAramaToolStripMenuItem.Name = "hastaAramaToolStripMenuItem";
            this.hastaAramaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.hastaAramaToolStripMenuItem.Text = "Hasta Arama";
            this.hastaAramaToolStripMenuItem.Click += new System.EventHandler(this.HastaArama_Click);
            // 
            // raporlarMenu
            // 
            this.raporlarMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaRaporlariToolStripMenuItem});
            this.raporlarMenu.Name = "raporlarMenu";
            this.raporlarMenu.Size = new System.Drawing.Size(62, 20);
            this.raporlarMenu.Text = "Raporlar";
            // 
            // hastaRaporlariToolStripMenuItem
            // 
            this.hastaRaporlariToolStripMenuItem.Name = "hastaRaporlariToolStripMenuItem";
            this.hastaRaporlariToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hastaRaporlariToolStripMenuItem.Text = "Hasta Raporları";
            this.hastaRaporlariToolStripMenuItem.Click += new System.EventHandler(this.HastaRaporlari_Click);
            // 
            // pencereMenu
            // 
            this.pencereMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basamakliToolStripMenuItem,
            this.yatayDoseToolStripMenuItem,
            this.dikeyDoseToolStripMenuItem,
            this.simgeleriDuzenleToolStripMenuItem});
            this.pencereMenu.Name = "pencereMenu";
            this.pencereMenu.Size = new System.Drawing.Size(57, 20);
            this.pencereMenu.Text = "Pencere";
            // 
            // basamakliToolStripMenuItem
            // 
            this.basamakliToolStripMenuItem.Name = "basamakliToolStripMenuItem";
            this.basamakliToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.basamakliToolStripMenuItem.Text = "Basamaklı";
            this.basamakliToolStripMenuItem.Click += new System.EventHandler(this.Basamakli_Click);
            // 
            // yatayDoseToolStripMenuItem
            // 
            this.yatayDoseToolStripMenuItem.Name = "yatayDoseToolStripMenuItem";
            this.yatayDoseToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.yatayDoseToolStripMenuItem.Text = "Yatay Döşe";
            this.yatayDoseToolStripMenuItem.Click += new System.EventHandler(this.YatayDose_Click);
            // 
            // dikeyDoseToolStripMenuItem
            // 
            this.dikeyDoseToolStripMenuItem.Name = "dikeyDoseToolStripMenuItem";
            this.dikeyDoseToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.dikeyDoseToolStripMenuItem.Text = "Dikey Döşe";
            this.dikeyDoseToolStripMenuItem.Click += new System.EventHandler(this.DikeyDose_Click);
            // 
            // simgeleriDuzenleToolStripMenuItem
            // 
            this.simgeleriDuzenleToolStripMenuItem.Name = "simgeleriDuzenleToolStripMenuItem";
            this.simgeleriDuzenleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.simgeleriDuzenleToolStripMenuItem.Text = "Simgeleri Düzenle";
            this.simgeleriDuzenleToolStripMenuItem.Click += new System.EventHandler(this.SimgeleriDuzenle_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblKullaniciBilgi});
            this.statusStrip.Location = new System.Drawing.Point(0, 739);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // lblKullaniciBilgi
            // 
            this.lblKullaniciBilgi.Name = "lblKullaniciBilgi";
            this.lblKullaniciBilgi.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOHATS - Sağlık Ocağı Hasta Takip Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem dosyaMenu;
        private System.Windows.Forms.ToolStripMenuItem oturumuKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referanslarMenu;
        private System.Windows.Forms.ToolStripMenuItem kullaniciIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikTanimlariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorTanimlariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaKabulMenu;
        private System.Windows.Forms.ToolStripMenuItem hastaIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniHastaKayitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaAramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarMenu;
        private System.Windows.Forms.ToolStripMenuItem hastaRaporlariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pencereMenu;
        private System.Windows.Forms.ToolStripMenuItem basamakliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yatayDoseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dikeyDoseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simgeleriDuzenleToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblKullaniciBilgi;
    }
}
