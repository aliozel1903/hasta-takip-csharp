using System;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace SOHATS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz.", 
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidateLogin(kullaniciAdi, sifre))
            {
                MessageBox.Show($"Hoş geldiniz, {CurrentUser.Ad} {CurrentUser.Soyad}!", 
                    "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ana formu aç
                MainForm mainForm = new MainForm();
                mainForm.Show();

                // Login formunu gizle
                this.Hide();

                // Ana form kapandığında login formunu da kapat
                mainForm.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", 
                    "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSifre.Clear();
                txtSifre.Focus();
            }
        }

        private bool ValidateLogin(string kullaniciAdi, string sifre)
        {
            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"
                            SELECT KullaniciKodu, Ad, Soyad, Yetki, Durum 
                            FROM Kullanici 
                            WHERE Ad = @Ad AND Sifre = @Sifre AND Durum = 'Aktif'";

                        command.Parameters.AddWithValue("@Ad", kullaniciAdi);
                        command.Parameters.AddWithValue("@Sifre", sifre);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Kullanıcı bilgilerini CurrentUser'a yükle
                                CurrentUser.KullaniciKodu = reader.GetInt32(0);
                                CurrentUser.Ad = reader.GetString(1);
                                CurrentUser.Soyad = reader.GetString(2);
                                CurrentUser.Yetki = reader.GetString(3);
                                CurrentUser.Durum = reader.GetString(4);

                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanı hatası: {ex.Message}", 
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
