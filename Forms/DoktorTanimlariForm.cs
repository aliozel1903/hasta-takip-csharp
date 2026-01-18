using System;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace SOHATS
{
    /// <summary>
    /// Doktor Tanıtma Formu
    /// </summary>
    public partial class DoktorTanimlariForm : Form
    {
        private string currentDoktorKodu = null;

        public DoktorTanimlariForm()
        {
            InitializeComponent();
            cmbUnvan.SelectedIndex = 0;
            EnsureDoktorTable();
            LoadDoktorlar();
        }

        private void EnsureDoktorTable()
        {
            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Doktor (
                            DoktorKodu TEXT PRIMARY KEY,
                            Ad TEXT NOT NULL,
                            Soyad TEXT NOT NULL,
                            Unvan TEXT,
                            Durum TEXT NOT NULL
                        )";
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch { }
        }

        private void LoadDoktorlar()
        {
            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "SELECT DoktorKodu, Unvan || ' ' || Ad || ' ' || Soyad AS AdSoyad, Durum FROM Doktor ORDER BY Ad";

                        var dt = new DataTable();
                        using (var reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                        dgvDoktorlar.DataSource = dt;
                    }
                }
            }
            catch { }
        }

        private void TxtDoktorKodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SearchDoktor();
            }
        }

        private void SearchDoktor()
        {
            string kod = txtDoktorKodu.Text.Trim();
            if (string.IsNullOrEmpty(kod)) return;

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM Doktor WHERE DoktorKodu = @DoktorKodu";
                        cmd.Parameters.AddWithValue("@DoktorKodu", kod);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                currentDoktorKodu = reader["DoktorKodu"].ToString();
                                txtAd.Text = reader["Ad"].ToString();
                                txtSoyad.Text = reader["Soyad"].ToString();
                                cmbUnvan.SelectedItem = reader["Unvan"].ToString();
                                chkAktif.Checked = reader["Durum"].ToString() == "Aktif";

                                btnKaydet.Enabled = false;
                                btnGuncelle.Enabled = true;
                                btnSil.Enabled = true;
                            }
                            else
                            {
                                if (MessageBox.Show($"'{kod}' kodlu doktor bulunamadı. Yeni kayıt açılsın mı?", "Kayıt Bulunamadı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    ClearForm();
                                    txtDoktorKodu.Text = kod;
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

        private void DgvDoktorlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtDoktorKodu.Text = dgvDoktorlar.Rows[e.RowIndex].Cells["DoktorKodu"].Value?.ToString();
            SearchDoktor();
        }

        private void BtnYeni_Click(object sender, EventArgs e)
        {
            ClearForm();
            txtDoktorKodu.Focus();
        }

        private void ClearForm()
        {
            currentDoktorKodu = null;
            txtDoktorKodu.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            cmbUnvan.SelectedIndex = 0;
            chkAktif.Checked = true;

            btnKaydet.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDoktorKodu.Text) || string.IsNullOrWhiteSpace(txtAd.Text))
            {
                MessageBox.Show("Doktor Kodu ve Ad zorunludur!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO Doktor (DoktorKodu, Ad, Soyad, Unvan, Durum) VALUES (@DoktorKodu, @Ad, @Soyad, @Unvan, @Durum)";
                        cmd.Parameters.AddWithValue("@DoktorKodu", txtDoktorKodu.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@Ad", txtAd.Text.Trim());
                        cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text.Trim());
                        cmd.Parameters.AddWithValue("@Unvan", cmbUnvan.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Durum", chkAktif.Checked ? "Aktif" : "Pasif");

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Doktor kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDoktorlar();
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
            if (string.IsNullOrEmpty(currentDoktorKodu)) return;

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE Doktor SET Ad=@Ad, Soyad=@Soyad, Unvan=@Unvan, Durum=@Durum WHERE DoktorKodu=@DoktorKodu";
                        cmd.Parameters.AddWithValue("@Ad", txtAd.Text.Trim());
                        cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text.Trim());
                        cmd.Parameters.AddWithValue("@Unvan", cmbUnvan.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Durum", chkAktif.Checked ? "Aktif" : "Pasif");
                        cmd.Parameters.AddWithValue("@DoktorKodu", currentDoktorKodu);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Doktor güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDoktorlar();
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
            if (string.IsNullOrEmpty(currentDoktorKodu)) return;

            if (MessageBox.Show("Bu doktoru silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM Doktor WHERE DoktorKodu = @DoktorKodu";
                        cmd.Parameters.AddWithValue("@DoktorKodu", currentDoktorKodu);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Doktor silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDoktorlar();
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
