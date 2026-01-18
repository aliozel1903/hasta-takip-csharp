using System;
using System.Windows.Forms;

namespace SOHATS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        /// <summary>
        /// Form yüklendiğinde yetki kontrolü yap
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplyPermissions();
            lblKullaniciBilgi.Text = $"Kullanıcı: {CurrentUser.Ad} {CurrentUser.Soyad} | Yetki: {CurrentUser.Yetki}";
        }

        /// <summary>
        /// Kullanıcı yetkisine göre menüleri gizle/göster
        /// </summary>
        private void ApplyPermissions()
        {
            // Referanslar menüsü sadece Admin için görünür
            referanslarMenu.Visible = CurrentUser.IsAdmin;
        }

        #region Dosya Menüsü Event Handlers

        private void OturumuKapat_Click(object sender, EventArgs e)
        {
            // Tüm child formları kapat
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }

            CurrentUser.Clear();
            
            // Login formunu göster
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            
            this.Hide();
            loginForm.FormClosed += (s, args) => this.Close();
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programdan çıkmak istediğinize emin misiniz?", 
                "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #endregion

        #region Referanslar Menüsü Event Handlers

        private void KullaniciIslemleri_Click(object sender, EventArgs e)
        {
            OpenChildForm<KullaniciIslemleriForm>();
        }

        private void PoliklinikTanimlari_Click(object sender, EventArgs e)
        {
            OpenChildForm<PoliklinikTanimlariForm>();
        }

        private void DoktorTanimlari_Click(object sender, EventArgs e)
        {
            OpenChildForm<DoktorTanimlariForm>();
        }

        #endregion

        #region Hasta Kabul Menüsü Event Handlers

        private void HastaIslemleri_Click(object sender, EventArgs e)
        {
            OpenChildForm<HastaIslemleriForm>();
        }

        private void YeniHastaKayit_Click(object sender, EventArgs e)
        {
            OpenChildForm<HastaKayitForm>();
        }

        private void HastaArama_Click(object sender, EventArgs e)
        {
            OpenChildForm<HastaAramaForm>();
        }

        #endregion

        #region Raporlar Menüsü Event Handlers

        private void HastaRaporlari_Click(object sender, EventArgs e)
        {
            OpenChildForm<RaporlarForm>();
        }

        #endregion

        #region Pencere Menüsü Event Handlers

        private void Basamakli_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void YatayDose_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void DikeyDose_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void SimgeleriDuzenle_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Child form aç. Aynı tipte form zaten açıksa öne getir.
        /// </summary>
        private void OpenChildForm<T>() where T : Form, new()
        {
            // Aynı tipte açık form var mı kontrol et
            foreach (Form child in this.MdiChildren)
            {
                if (child is T)
                {
                    child.Activate();
                    if (child.WindowState == FormWindowState.Minimized)
                    {
                        child.WindowState = FormWindowState.Normal;
                    }
                    return;
                }
            }

            // Yeni form oluştur
            T form = new T();
            form.MdiParent = this;
            form.Show();
        }

        #endregion
    }
}
