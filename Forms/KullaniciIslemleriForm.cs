using System;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace SOHATS
{
    /// <summary>
    /// Kullanıcı Tanıtma Formu
    /// </summary>
    public partial class KullaniciIslemleriForm : Form
    {
        private int? currentKullaniciKodu = null;

        public KullaniciIslemleriForm()
        {
            InitializeComponent();
            cmbYetki.SelectedIndex = 1;
            LoadKullanicilar();
        }

        private void LoadKullanicilar()
        {
            cmbKullaniciKodu.Items.Clear();
            cmbKullaniciKodu.Items.Add("-- Seçiniz --");

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "SELECT KullaniciKodu, Ad FROM Kullanici ORDER BY Ad";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbKullaniciKodu.Items.Add(new ComboBoxItem(reader["KullaniciKodu"].ToString(), reader["Ad"].ToString()));
                            }
                        }
                    }
                }
            }
            catch { }

            cmbKullaniciKodu.SelectedIndex = 0;
        }

        private void CmbKullaniciKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKullaniciKodu.SelectedIndex <= 0)
            {
                ClearForm();
                return;
            }

            var selected = cmbKullaniciKodu.SelectedItem as ComboBoxItem;
            if (selected == null) return;

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM Kullanici WHERE KullaniciKodu = @KullaniciKodu";
                        cmd.Parameters.AddWithValue("@KullaniciKodu", int.Parse(selected.Value));

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                currentKullaniciKodu = reader.GetInt32(0);
                                txtAd.Text = reader["Ad"].ToString();
                                txtSoyad.Text = reader["Soyad"].ToString();
                                txtSifre.Text = reader["Sifre"].ToString();
                                cmbYetki.SelectedItem = reader["Yetki"].ToString();
                                chkAktif.Checked = reader["Durum"].ToString() == "Aktif";

                                btnKaydet.Enabled = false;
                                btnGuncelle.Enabled = true;
                                btnSil.Enabled = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnYeniKullaniciEkle_Click(object sender, EventArgs e)
        {
            ClearForm();
            cmbKullaniciKodu.SelectedIndex = 0;
            txtAd.Focus();
        }

        private void ClearForm()
        {
            currentKullaniciKodu = null;
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtSifre.Text = "";
            cmbYetki.SelectedIndex = 1;
            chkAktif.Checked = true;

            btnKaydet.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Ad ve Şifre zorunludur!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO Kullanici (Ad, Soyad, Sifre, Yetki, Durum) VALUES (@Ad, @Soyad, @Sifre, @Yetki, @Durum)";
                        cmd.Parameters.AddWithValue("@Ad", txtAd.Text.Trim());
                        cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text.Trim());
                        cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                        cmd.Parameters.AddWithValue("@Yetki", cmbYetki.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Durum", chkAktif.Checked ? "Aktif" : "Pasif");

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Kullanıcı kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadKullanicilar();
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıt hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (currentKullaniciKodu == null) return;

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE Kullanici SET Ad=@Ad, Soyad=@Soyad, Sifre=@Sifre, Yetki=@Yetki, Durum=@Durum WHERE KullaniciKodu=@KullaniciKodu";
                        cmd.Parameters.AddWithValue("@Ad", txtAd.Text.Trim());
                        cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text.Trim());
                        cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                        cmd.Parameters.AddWithValue("@Yetki", cmbYetki.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Durum", chkAktif.Checked ? "Aktif" : "Pasif");
                        cmd.Parameters.AddWithValue("@KullaniciKodu", currentKullaniciKodu.Value);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Kullanıcı güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadKullanicilar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (currentKullaniciKodu == null) return;

            if (MessageBox.Show("Bu kullanıcıyı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM Kullanici WHERE KullaniciKodu = @KullaniciKodu";
                        cmd.Parameters.AddWithValue("@KullaniciKodu", currentKullaniciKodu.Value);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Kullanıcı silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadKullanicilar();
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Silme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
