using System;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace SOHATS
{
    /// <summary>
    /// Hasta Kayıt Formu - Yeni hasta ekleme
    /// </summary>
    public partial class HastaKayitForm : Form
    {
        private string currentDosyaNo = null;

        public HastaKayitForm()
        {
            InitializeComponent();
            cmbCinsiyet.SelectedIndex = 0;
        }

        private void TxtDosyaNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SearchHasta();
            }
        }

        private void SearchHasta()
        {
            string dosyaNo = txtDosyaNo.Text.Trim();
            if (string.IsNullOrEmpty(dosyaNo)) return;

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM Hasta WHERE DosyaNo = @DosyaNo";
                        cmd.Parameters.AddWithValue("@DosyaNo", dosyaNo);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                currentDosyaNo = reader["DosyaNo"].ToString();
                                txtTCNo.Text = reader["TCNo"]?.ToString();
                                txtAd.Text = reader["Ad"]?.ToString();
                                txtSoyad.Text = reader["Soyad"]?.ToString();
                                txtDogumYeri.Text = reader["DogumYeri"]?.ToString();
                                
                                if (DateTime.TryParse(reader["DogumTarihi"]?.ToString(), out DateTime dogumTarihi))
                                    dtpDogumTarihi.Value = dogumTarihi;

                                txtBabaAdi.Text = reader["BabaAdi"]?.ToString();
                                txtAnaAdi.Text = reader["AnaAdi"]?.ToString();
                                cmbCinsiyet.SelectedItem = reader["Cinsiyet"]?.ToString();
                                txtKurumAdi.Text = reader["KurumAdi"]?.ToString();

                                btnKaydet.Enabled = false;
                                btnGuncelle.Enabled = true;
                                btnSil.Enabled = true;

                                MessageBox.Show("Hasta bulundu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                if (MessageBox.Show("Hasta bulunamadı. Yeni kayıt oluşturulsun mu?", "Kayıt Bulunamadı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    ClearForm();
                                    txtDosyaNo.Text = dosyaNo;
                                    btnKaydet.Enabled = true;
                                }
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

        private void BtnYeni_Click(object sender, EventArgs e)
        {
            ClearForm();
            txtDosyaNo.Focus();
        }

        private void ClearForm()
        {
            currentDosyaNo = null;
            txtDosyaNo.Text = "";
            txtTCNo.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtDogumYeri.Text = "";
            dtpDogumTarihi.Value = DateTime.Now;
            txtBabaAdi.Text = "";
            txtAnaAdi.Text = "";
            cmbCinsiyet.SelectedIndex = 0;
            txtKurumAdi.Text = "";

            btnKaydet.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDosyaNo.Text) || string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Dosya No, Ad ve Soyad zorunludur!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = @"INSERT INTO Hasta (DosyaNo, TCNo, Ad, Soyad, DogumYeri, DogumTarihi, BabaAdi, AnaAdi, Cinsiyet, KurumAdi) 
                                           VALUES (@DosyaNo, @TCNo, @Ad, @Soyad, @DogumYeri, @DogumTarihi, @BabaAdi, @AnaAdi, @Cinsiyet, @KurumAdi)";
                        
                        cmd.Parameters.AddWithValue("@DosyaNo", txtDosyaNo.Text.Trim());
                        cmd.Parameters.AddWithValue("@TCNo", txtTCNo.Text.Trim());
                        cmd.Parameters.AddWithValue("@Ad", txtAd.Text.Trim());
                        cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text.Trim());
                        cmd.Parameters.AddWithValue("@DogumYeri", txtDogumYeri.Text.Trim());
                        cmd.Parameters.AddWithValue("@DogumTarihi", dtpDogumTarihi.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@BabaAdi", txtBabaAdi.Text.Trim());
                        cmd.Parameters.AddWithValue("@AnaAdi", txtAnaAdi.Text.Trim());
                        cmd.Parameters.AddWithValue("@Cinsiyet", cmbCinsiyet.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@KurumAdi", txtKurumAdi.Text.Trim());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Hasta kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        currentDosyaNo = txtDosyaNo.Text.Trim();
                        btnKaydet.Enabled = false;
                        btnGuncelle.Enabled = true;
                        btnSil.Enabled = true;
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
            if (string.IsNullOrEmpty(currentDosyaNo)) return;

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = @"UPDATE Hasta SET TCNo=@TCNo, Ad=@Ad, Soyad=@Soyad, DogumYeri=@DogumYeri, 
                                           DogumTarihi=@DogumTarihi, BabaAdi=@BabaAdi, AnaAdi=@AnaAdi, Cinsiyet=@Cinsiyet, KurumAdi=@KurumAdi 
                                           WHERE DosyaNo=@DosyaNo";

                        cmd.Parameters.AddWithValue("@TCNo", txtTCNo.Text.Trim());
                        cmd.Parameters.AddWithValue("@Ad", txtAd.Text.Trim());
                        cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text.Trim());
                        cmd.Parameters.AddWithValue("@DogumYeri", txtDogumYeri.Text.Trim());
                        cmd.Parameters.AddWithValue("@DogumTarihi", dtpDogumTarihi.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@BabaAdi", txtBabaAdi.Text.Trim());
                        cmd.Parameters.AddWithValue("@AnaAdi", txtAnaAdi.Text.Trim());
                        cmd.Parameters.AddWithValue("@Cinsiyet", cmbCinsiyet.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@KurumAdi", txtKurumAdi.Text.Trim());
                        cmd.Parameters.AddWithValue("@DosyaNo", currentDosyaNo);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Hasta güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrEmpty(currentDosyaNo)) return;

            if (MessageBox.Show("Bu hastayı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM Hasta WHERE DosyaNo = @DosyaNo";
                        cmd.Parameters.AddWithValue("@DosyaNo", currentDosyaNo);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Hasta silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
