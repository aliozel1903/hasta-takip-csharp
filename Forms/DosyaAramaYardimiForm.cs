using System;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace SOHATS
{
    /// <summary>
    /// Dosya Arama Yardımı Dialog Formu
    /// </summary>
    public partial class DosyaAramaYardimiForm : Form
    {
        public string SecilenDosyaNo { get; private set; }

        public DosyaAramaYardimiForm()
        {
            InitializeComponent();
        }

        private void TxtArama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BtnAra_Click(sender, e);
            }
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            string aramaMetni = txtArama.Text.Trim();
            if (string.IsNullOrEmpty(aramaMetni))
            {
                MessageBox.Show("Arama metni giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"
                            SELECT DosyaNo, TCNo, Ad, Soyad, DogumTarihi 
                            FROM Hasta 
                            WHERE Ad LIKE @Arama OR Soyad LIKE @Arama OR TCNo LIKE @Arama OR DosyaNo LIKE @Arama
                            ORDER BY Ad, Soyad";
                        command.Parameters.AddWithValue("@Arama", "%" + aramaMetni + "%");

                        var dt = new DataTable();
                        using (var reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }

                        dgvSonuclar.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Sonuç bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Arama hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvSonuclar_DoubleClick(object sender, EventArgs e)
        {
            BtnSec_Click(sender, e);
        }

        private void BtnSec_Click(object sender, EventArgs e)
        {
            if (dgvSonuclar.SelectedRows.Count > 0)
            {
                SecilenDosyaNo = dgvSonuclar.SelectedRows[0].Cells["DosyaNo"].Value?.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
