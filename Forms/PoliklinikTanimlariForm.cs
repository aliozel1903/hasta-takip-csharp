using System;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace SOHATS
{
    /// <summary>
    /// Poliklinik Tanımları Formu
    /// </summary>
    public partial class PoliklinikTanimlariForm : Form
    {
        private int? currentPoliklinikID = null;

        public PoliklinikTanimlariForm()
        {
            InitializeComponent();
            LoadPoliklinikler();
        }

        private void LoadPoliklinikler()
        {
            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "SELECT PoliklinikID, PoliklinikAdi, Durum FROM Poliklinik ORDER BY PoliklinikAdi";

                        var dt = new DataTable();
                        using (var reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                        dgvPoliklinikler.DataSource = dt;
                    }
                }
            }
            catch { }
        }

        private void TxtPoliklinikAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SearchPoliklinik();
            }
        }

        private void SearchPoliklinik()
        {
            string poliklinikAdi = txtPoliklinikAdi.Text.Trim();
            if (string.IsNullOrEmpty(poliklinikAdi)) return;

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "SELECT PoliklinikID, PoliklinikAdi, Durum FROM Poliklinik WHERE PoliklinikAdi = @PoliklinikAdi";
                        cmd.Parameters.AddWithValue("@PoliklinikAdi", poliklinikAdi);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                currentPoliklinikID = reader.GetInt32(0);
                                txtPoliklinikAdi.Text = reader.GetString(1);
                                chkGecerli.Checked = reader.GetString(2) == "Gecerli";

                                btnKaydet.Enabled = false;
                                btnGuncelle.Enabled = true;
                                btnSil.Enabled = true;

                                MessageBox.Show("Kayıt bulundu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                if (MessageBox.Show($"'{poliklinikAdi}' adlı poliklinik bulunamadı.\nYeni kayıt yapılsın mı?", "Kayıt Bulunamadı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    ClearForm();
                                    txtPoliklinikAdi.Text = poliklinikAdi;
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

        private void DgvPoliklinikler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtPoliklinikAdi.Text = dgvPoliklinikler.Rows[e.RowIndex].Cells["PoliklinikAdi"].Value?.ToString();
            SearchPoliklinik();
        }

        private void BtnYeni_Click(object sender, EventArgs e)
        {
            ClearForm();
            txtPoliklinikAdi.Focus();
        }

        private void ClearForm()
        {
            currentPoliklinikID = null;
            txtPoliklinikAdi.Text = "";
            chkGecerli.Checked = true;
            btnKaydet.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string poliklinikAdi = txtPoliklinikAdi.Text.Trim();

            if (string.IsNullOrEmpty(poliklinikAdi))
            {
                MessageBox.Show("Poliklinik adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string durum = chkGecerli.Checked ? "Gecerli" : "Gecersiz";

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO Poliklinik (PoliklinikAdi, Durum) VALUES (@PoliklinikAdi, @Durum)";
                        cmd.Parameters.AddWithValue("@PoliklinikAdi", poliklinikAdi);
                        cmd.Parameters.AddWithValue("@Durum", durum);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Poliklinik kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPoliklinikler();
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
            if (currentPoliklinikID == null) return;

            string poliklinikAdi = txtPoliklinikAdi.Text.Trim();
            string durum = chkGecerli.Checked ? "Gecerli" : "Gecersiz";

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE Poliklinik SET PoliklinikAdi = @PoliklinikAdi, Durum = @Durum WHERE PoliklinikID = @PoliklinikID";
                        cmd.Parameters.AddWithValue("@PoliklinikAdi", poliklinikAdi);
                        cmd.Parameters.AddWithValue("@Durum", durum);
                        cmd.Parameters.AddWithValue("@PoliklinikID", currentPoliklinikID.Value);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Poliklinik güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPoliklinikler();
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
            if (currentPoliklinikID == null) return;

            if (MessageBox.Show("Bu poliklinik kaydını silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM Poliklinik WHERE PoliklinikID = @PoliklinikID";
                        cmd.Parameters.AddWithValue("@PoliklinikID", currentPoliklinikID.Value);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Poliklinik silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPoliklinikler();
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
