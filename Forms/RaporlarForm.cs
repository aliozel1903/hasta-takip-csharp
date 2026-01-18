using System;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SOHATS
{
    /// <summary>
    /// Raporlar Formu
    /// </summary>
    public partial class RaporlarForm : Form
    {
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private DataTable dataTable;

        public RaporlarForm()
        {
            InitializeComponent();
            dtpBaslangic.Value = DateTime.Now.AddMonths(-1);
            dtpBitis.Value = DateTime.Now;
            InitializePrint();
        }

        private void InitializePrint()
        {
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            printPreviewDialog = new PrintPreviewDialog { Document = printDocument, Width = 800, Height = 600 };
        }

        private void BtnSorgula_Click(object sender, EventArgs e)
        {
            if (dtpBaslangic.Value > dtpBitis.Value)
            {
                MessageBox.Show("Başlangıç tarihi bitiş tarihinden büyük olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tarih1 = dtpBaslangic.Value.ToString("yyyy-MM-dd");
            string tarih2 = dtpBitis.Value.ToString("yyyy-MM-dd");

            int? taburcuFiltre = null;
            if (rbTaburcuOlmus.Checked) taburcuFiltre = 1;
            else if (rbTaburcuOlmamis.Checked) taburcuFiltre = 0;

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        string query = @"
                            SELECT 
                                s.DosyaNo as dosyano,
                                h.Ad as ad,
                                h.Soyad as soyad,
                                s.SevkTarihi as sevktarih,
                                s.ToplamTutar as tutar
                            FROM Sevk s
                            INNER JOIN Hasta h ON s.DosyaNo = h.DosyaNo
                            WHERE s.SevkTarihi BETWEEN @Tarih1 AND @Tarih2";

                        if (taburcuFiltre.HasValue)
                        {
                            query += " AND s.Taburcu = @Taburcu";
                        }

                        query += " ORDER BY s.SevkTarihi DESC";

                        command.CommandText = query;
                        command.Parameters.AddWithValue("@Tarih1", tarih1);
                        command.Parameters.AddWithValue("@Tarih2", tarih2);

                        if (taburcuFiltre.HasValue)
                        {
                            command.Parameters.AddWithValue("@Taburcu", taburcuFiltre.Value);
                        }

                        dataTable = new DataTable();
                        using (var reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }

                        dgvSonuclar.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Kayıt bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sorgulama hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            dtpBaslangic.Value = DateTime.Now.AddMonths(-1);
            dtpBitis.Value = DateTime.Now;
            rbHepsi.Checked = true;
            dgvSonuclar.DataSource = null;
            dataTable = null;
        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Yazdırılacak veri yok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                printPreviewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yazdırma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Font dataFont = new Font("Segoe UI", 9);

            e.Graphics.DrawString("SOHATS - Hasta Raporu", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += 30;

            e.Graphics.DrawString($"Tarih: {dtpBaslangic.Value:dd.MM.yyyy} - {dtpBitis.Value:dd.MM.yyyy}", dataFont, Brushes.Black, leftMargin, yPos);
            yPos += 25;

            foreach (DataRow row in dataTable.Rows)
            {
                string line = $"{row["dosyano"]} - {row["ad"]} {row["soyad"]} - {row["sevktarih"]}";
                e.Graphics.DrawString(line, dataFont, Brushes.Black, leftMargin, yPos);
                yPos += 20;

                if (yPos > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }
    }
}
