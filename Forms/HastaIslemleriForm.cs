using System;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SOHATS
{
    /// <summary>
    /// Hasta İşlemleri Formu
    /// </summary>
    public partial class HastaIslemleriForm : Form
    {
        // Durum
        private string currentDosyaNo = null;
        private string currentSevkTarihi = null;
        private bool sevkAcik = false;
        private int siraNo = 1;

        // Yazdırma
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;

        public HastaIslemleriForm()
        {
            InitializeComponent();
            SetupGridColumns();
            LoadComboBoxData();
            InitializePrint();
        }

        private void SetupGridColumns()
        {
            dgvIslemler.Columns.Clear();
            dgvIslemler.Columns.Add(new DataGridViewTextBoxColumn { Name = "IslemID", HeaderText = "ID", Visible = false });
            dgvIslemler.Columns.Add(new DataGridViewTextBoxColumn { Name = "Poliklinik", HeaderText = "POLİKLİNİK" });
            dgvIslemler.Columns.Add(new DataGridViewTextBoxColumn { Name = "SiraNo", HeaderText = "SIRA NO", Width = 60 });
            dgvIslemler.Columns.Add(new DataGridViewTextBoxColumn { Name = "Saat", HeaderText = "SAAT", Width = 60 });
            dgvIslemler.Columns.Add(new DataGridViewTextBoxColumn { Name = "YapilanIslem", HeaderText = "YAPILAN İŞLEM" });
            dgvIslemler.Columns.Add(new DataGridViewTextBoxColumn { Name = "DrKodu", HeaderText = "DR.KODU" });
            dgvIslemler.Columns.Add(new DataGridViewTextBoxColumn { Name = "Miktar", HeaderText = "MİKTAR", Width = 60 });
            dgvIslemler.Columns.Add(new DataGridViewTextBoxColumn { Name = "BirimFiyat", HeaderText = "BİRİM FİYATI", Width = 80 });
            dgvIslemler.Columns.Add(new DataGridViewTextBoxColumn { Name = "Tutar", HeaderText = "TUTAR", Width = 80 });
        }

        private void InitializePrint()
        {
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            printPreviewDialog = new PrintPreviewDialog { Document = printDocument, Width = 800, Height = 600 };
        }

        private void LoadComboBoxData()
        {
            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();

                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "SELECT PoliklinikID, PoliklinikAdi FROM Poliklinik WHERE Durum = 'Gecerli'";

                        cmbPoliklinik.Items.Clear();
                        cmbPoliklinik.Items.Add(new ComboBoxItem("", "-- Seçiniz --"));

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbPoliklinik.Items.Add(new ComboBoxItem(reader["PoliklinikID"].ToString(), reader["PoliklinikAdi"].ToString()));
                            }
                        }
                        cmbPoliklinik.SelectedIndex = 0;
                    }

                    cmbDrKodu.Items.Clear();
                    cmbDrKodu.Items.Add(new ComboBoxItem("", "--"));
                    cmbDrKodu.Items.Add(new ComboBoxItem("DR01", "DR01"));
                    cmbDrKodu.Items.Add(new ComboBoxItem("DR02", "DR02"));
                    cmbDrKodu.SelectedIndex = 0;
                }
            }
            catch
            {
                cmbPoliklinik.Items.Clear();
                cmbPoliklinik.Items.Add(new ComboBoxItem("", "-- Seçiniz --"));
                cmbPoliklinik.SelectedIndex = 0;

                cmbDrKodu.Items.Clear();
                cmbDrKodu.Items.Add(new ComboBoxItem("", "--"));
                cmbDrKodu.Items.Add(new ComboBoxItem("DR01", "DR01"));
                cmbDrKodu.Items.Add(new ComboBoxItem("DR02", "DR02"));
                cmbDrKodu.SelectedIndex = 0;
            }
        }

        private void DgvIslemler_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        #region Event Handlers

        private void TxtDosyaNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SearchHasta();
            }
        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            using (var aramaForm = new DosyaAramaYardimiForm())
            {
                if (aramaForm.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(aramaForm.SecilenDosyaNo))
                {
                    txtDosyaNo.Text = aramaForm.SecilenDosyaNo;
                    SearchHasta();
                }
            }
        }

        private void SearchHasta()
        {
            string dosyaNo = txtDosyaNo.Text.Trim();
            if (string.IsNullOrEmpty(dosyaNo))
            {
                MessageBox.Show("Dosya numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT DosyaNo, Ad, Soyad, KurumAdi FROM Hasta WHERE DosyaNo = @DosyaNo";
                        command.Parameters.AddWithValue("@DosyaNo", dosyaNo);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                currentDosyaNo = reader["DosyaNo"].ToString();
                                txtHastaAdi.Text = reader["Ad"]?.ToString();
                                txtSoyadi.Text = reader["Soyad"]?.ToString();
                                txtKurumAdi.Text = reader["KurumAdi"]?.ToString();

                                LoadOncekiIslemler(connection);
                                CheckOrCreateSevk(connection);
                            }
                            else
                            {
                                MessageBox.Show("Hasta bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                BtnBul_Click(null, null);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Arama hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOncekiIslemler(SqliteConnection connection)
        {
            cmbOncekiIslemler.Items.Clear();

            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = "SELECT SevkTarihi FROM Sevk WHERE DosyaNo = @DosyaNo ORDER BY SevkTarihi DESC";
                cmd.Parameters.AddWithValue("@DosyaNo", currentDosyaNo);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbOncekiIslemler.Items.Add(reader["SevkTarihi"].ToString());
                    }
                }
            }

            if (cmbOncekiIslemler.Items.Count > 0)
                cmbOncekiIslemler.SelectedIndex = 0;
        }

        private void CheckOrCreateSevk(SqliteConnection connection)
        {
            string bugun = DateTime.Now.ToString("yyyy-MM-dd");

            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = "SELECT COUNT(*) FROM Sevk WHERE DosyaNo = @DosyaNo AND SevkTarihi = @SevkTarihi";
                cmd.Parameters.AddWithValue("@DosyaNo", currentDosyaNo);
                cmd.Parameters.AddWithValue("@SevkTarihi", bugun);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 0)
                {
                    using (var insertCmd = connection.CreateCommand())
                    {
                        insertCmd.CommandText = @"INSERT INTO Sevk (DosyaNo, SevkTarihi, Saat, DrKodu, Miktar, BirimFiyat, ToplamTutar, Taburcu) VALUES (@DosyaNo, @SevkTarihi, @Saat, '', 0, 0, 0, 0)";
                        insertCmd.Parameters.AddWithValue("@DosyaNo", currentDosyaNo);
                        insertCmd.Parameters.AddWithValue("@SevkTarihi", bugun);
                        insertCmd.Parameters.AddWithValue("@Saat", DateTime.Now.ToString("HH:mm"));
                        insertCmd.ExecuteNonQuery();
                    }
                }

                currentSevkTarihi = bugun;
                dtpSevkTarihi.Value = DateTime.Now;
                sevkAcik = true;
                siraNo = 1;
                txtSiraNo.Text = siraNo.ToString();

                LoadIslemler(connection);
            }
        }

        private void BtnGit_Click(object sender, EventArgs e)
        {
            if (cmbOncekiIslemler.SelectedItem == null) return;

            currentSevkTarihi = cmbOncekiIslemler.SelectedItem.ToString();

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    LoadIslemler(connection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHastaBilgileri_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentDosyaNo))
            {
                MessageBox.Show("Önce hasta seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Hasta: {txtHastaAdi.Text} {txtSoyadi.Text}\nDosya No: {currentDosyaNo}\nKurum: {txtKurumAdi.Text}", "Hasta Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadIslemler(SqliteConnection connection)
        {
            dgvIslemler.Rows.Clear();
            siraNo = 1;

            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT i.IslemID, i.IslemAdi, i.DrKodu, i.Miktar, i.BirimFiyat FROM Islem i WHERE i.DosyaNo = @DosyaNo AND i.SevkTarihi = @SevkTarihi ORDER BY i.IslemID";
                command.Parameters.AddWithValue("@DosyaNo", currentDosyaNo);
                command.Parameters.AddWithValue("@SevkTarihi", currentSevkTarihi);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int miktar = Convert.ToInt32(reader["Miktar"]);
                        decimal birimFiyat = Convert.ToDecimal(reader["BirimFiyat"]);
                        decimal tutar = miktar * birimFiyat;

                        dgvIslemler.Rows.Add(
                            reader["IslemID"].ToString(),
                            "",
                            siraNo++.ToString(),
                            DateTime.Now.ToString("HH:mm"),
                            reader["IslemAdi"].ToString(),
                            reader["DrKodu"].ToString(),
                            miktar.ToString(),
                            birimFiyat.ToString("N2"),
                            tutar.ToString("N2")
                        );
                    }
                }
            }

            txtSiraNo.Text = siraNo.ToString();
            CalculateTotal();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentDosyaNo) || string.IsNullOrEmpty(currentSevkTarihi))
            {
                MessageBox.Show("Önce hasta seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string islemAdi = txtYapilanIslem.Text.Trim();
            if (string.IsNullOrEmpty(islemAdi))
            {
                MessageBox.Show("Yapılan işlem giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYapilanIslem.Focus();
                return;
            }

            var selectedDoktor = cmbDrKodu.SelectedItem as ComboBoxItem;
            string drKodu = selectedDoktor?.Value ?? "";
            int miktar = (int)numMiktar.Value;
            decimal birimFiyat = numBirimFiyat.Value;
            string saat = DateTime.Now.ToString("HH:mm");

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"INSERT INTO Islem (DosyaNo, SevkTarihi, IslemAdi, DrKodu, Miktar, BirimFiyat) VALUES (@DosyaNo, @SevkTarihi, @IslemAdi, @DrKodu, @Miktar, @BirimFiyat)";
                        command.Parameters.AddWithValue("@DosyaNo", currentDosyaNo);
                        command.Parameters.AddWithValue("@SevkTarihi", currentSevkTarihi);
                        command.Parameters.AddWithValue("@IslemAdi", islemAdi);
                        command.Parameters.AddWithValue("@DrKodu", drKodu);
                        command.Parameters.AddWithValue("@Miktar", miktar);
                        command.Parameters.AddWithValue("@BirimFiyat", birimFiyat);

                        command.ExecuteNonQuery();

                        command.CommandText = "SELECT last_insert_rowid()";
                        long islemId = Convert.ToInt64(command.ExecuteScalar());

                        var selectedPoli = cmbPoliklinik.SelectedItem as ComboBoxItem;
                        decimal tutar = miktar * birimFiyat;

                        dgvIslemler.Rows.Add(
                            islemId.ToString(),
                            selectedPoli?.Text ?? "",
                            siraNo++.ToString(),
                            saat,
                            islemAdi,
                            drKodu,
                            miktar.ToString(),
                            birimFiyat.ToString("N2"),
                            tutar.ToString("N2")
                        );

                        txtSiraNo.Text = siraNo.ToString();
                        CalculateTotal();
                        UpdateSevkToplam(connection);

                        txtYapilanIslem.Text = "";
                        numMiktar.Value = 1;
                        numBirimFiyat.Value = 0;
                        txtYapilanIslem.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İşlem ekleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateTotal()
        {
            decimal toplam = 0;

            foreach (DataGridViewRow row in dgvIslemler.Rows)
            {
                if (row.Cells["Tutar"].Value != null)
                {
                    string tutarStr = row.Cells["Tutar"].Value.ToString().Replace(",", ".");
                    if (decimal.TryParse(tutarStr, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal tutar))
                    {
                        toplam += tutar;
                    }
                }
            }

            lblToplamTutar.Text = toplam.ToString("N2");
        }

        private void UpdateSevkToplam(SqliteConnection connection)
        {
            decimal toplam = 0;
            foreach (DataGridViewRow row in dgvIslemler.Rows)
            {
                if (row.Cells["Tutar"].Value != null)
                {
                    string tutarStr = row.Cells["Tutar"].Value.ToString().Replace(",", ".");
                    if (decimal.TryParse(tutarStr, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal tutar))
                    {
                        toplam += tutar;
                    }
                }
            }

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE Sevk SET ToplamTutar = @ToplamTutar WHERE DosyaNo = @DosyaNo AND SevkTarihi = @SevkTarihi";
                command.Parameters.AddWithValue("@ToplamTutar", toplam);
                command.Parameters.AddWithValue("@DosyaNo", currentDosyaNo);
                command.Parameters.AddWithValue("@SevkTarihi", currentSevkTarihi);
                command.ExecuteNonQuery();
            }
        }

        private void BtnYeni_Click(object sender, EventArgs e)
        {
            txtDosyaNo.Text = "";
            txtHastaAdi.Text = "";
            txtSoyadi.Text = "";
            txtKurumAdi.Text = "";
            dtpSevkTarihi.Value = DateTime.Now;
            cmbOncekiIslemler.Items.Clear();
            dgvIslemler.Rows.Clear();
            lblToplamTutar.Text = "0,00";
            currentDosyaNo = null;
            currentSevkTarihi = null;
            sevkAcik = false;
            siraNo = 1;
            txtSiraNo.Text = "1";

            txtDosyaNo.Focus();
        }

        private void BtnSecSil_Click(object sender, EventArgs e)
        {
            if (dgvIslemler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek işlemi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçili işlemi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                string islemIdStr = dgvIslemler.SelectedRows[0].Cells["IslemID"].Value?.ToString();
                if (string.IsNullOrEmpty(islemIdStr)) return;

                int islemId = int.Parse(islemIdStr);

                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "DELETE FROM Islem WHERE IslemID = @IslemID";
                        command.Parameters.AddWithValue("@IslemID", islemId);
                        command.ExecuteNonQuery();
                    }

                    dgvIslemler.Rows.RemoveAt(dgvIslemler.SelectedRows[0].Index);
                    CalculateTotal();
                    UpdateSevkToplam(connection);

                    MessageBox.Show("İşlem silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Silme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTaburcu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentDosyaNo) || string.IsNullOrEmpty(currentSevkTarihi))
            {
                MessageBox.Show("Önce hasta seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "UPDATE Sevk SET Taburcu = 1, Saat = @CikisSaati WHERE DosyaNo = @DosyaNo AND SevkTarihi = @SevkTarihi";
                        command.Parameters.AddWithValue("@CikisSaati", DateTime.Now.ToString("HH:mm"));
                        command.Parameters.AddWithValue("@DosyaNo", currentDosyaNo);
                        command.Parameters.AddWithValue("@SevkTarihi", currentSevkTarihi);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Hasta taburcu edildi.\nÇıkış Saati: {DateTime.Now:HH:mm}", "Taburcu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Taburcu hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            if (dgvIslemler.Rows.Count == 0)
            {
                MessageBox.Show("Yazdırılacak işlem yok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yazdırma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBaskiOnizleme_Click(object sender, EventArgs e)
        {
            if (dgvIslemler.Rows.Count == 0)
            {
                MessageBox.Show("Önizlenecek işlem yok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                printPreviewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Önizleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float yPos = e.MarginBounds.Top;
            float leftMargin = e.MarginBounds.Left;

            Font headerFont = new Font("Segoe UI", 14, FontStyle.Bold);
            Font normalFont = new Font("Segoe UI", 10);
            Font smallFont = new Font("Segoe UI", 9);

            e.Graphics.DrawString("SOHATS - Hasta İşlem Raporu", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += 30;

            e.Graphics.DrawString($"Dosya No: {currentDosyaNo}    Hasta: {txtHastaAdi.Text} {txtSoyadi.Text}", normalFont, Brushes.Black, leftMargin, yPos);
            yPos += 25;
            e.Graphics.DrawString($"Sevk Tarihi: {currentSevkTarihi}", normalFont, Brushes.Black, leftMargin, yPos);
            yPos += 30;

            foreach (DataGridViewRow row in dgvIslemler.Rows)
            {
                string line = $"{row.Cells["SiraNo"].Value}. {row.Cells["YapilanIslem"].Value} - {row.Cells["Miktar"].Value} x {row.Cells["BirimFiyat"].Value} = {row.Cells["Tutar"].Value} TL";
                e.Graphics.DrawString(line, smallFont, Brushes.Black, leftMargin, yPos);
                yPos += 20;
            }

            yPos += 10;
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + 400, yPos);
            yPos += 10;
            e.Graphics.DrawString($"TOPLAM: {lblToplamTutar.Text} TL", headerFont, Brushes.Black, leftMargin, yPos);
        }

        #endregion
    }

    public class ComboBoxItem
    {
        public string Value { get; set; }
        public string Text { get; set; }

        public ComboBoxItem(string value, string text)
        {
            Value = value;
            Text = text;
        }

        public override string ToString() => Text;
    }
}
