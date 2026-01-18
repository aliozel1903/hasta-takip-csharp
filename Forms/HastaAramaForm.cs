using System;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace SOHATS
{
    /// <summary>
    /// Hasta Arama Formu - Hasta listesi ve arama
    /// </summary>
    public partial class HastaAramaForm : Form
    {
        public string SecilenDosyaNo { get; private set; }

        public HastaAramaForm()
        {
            InitializeComponent();
            LoadHastalar();
        }

        private void LoadHastalar()
        {
            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "SELECT DosyaNo, TCNo, Ad, Soyad, Cinsiyet FROM Hasta ORDER BY Ad, Soyad";

                        var dt = new DataTable();
                        using (var reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                        dgvHastalar.DataSource = dt;
                    }
                }
            }
            catch { }
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
            string arama = txtArama.Text.Trim();

            try
            {
                using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = @"SELECT DosyaNo, TCNo, Ad, Soyad, Cinsiyet FROM Hasta 
                                           WHERE Ad LIKE @Arama OR Soyad LIKE @Arama OR TCNo LIKE @Arama OR DosyaNo LIKE @Arama
                                           ORDER BY Ad, Soyad";
                        cmd.Parameters.AddWithValue("@Arama", "%" + arama + "%");

                        var dt = new DataTable();
                        using (var reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                        dgvHastalar.DataSource = dt;
                    }
                }
            }
            catch { }
        }

        private void DgvHastalar_DoubleClick(object sender, EventArgs e)
        {
            BtnSec_Click(sender, e);
        }

        private void BtnSec_Click(object sender, EventArgs e)
        {
            if (dgvHastalar.SelectedRows.Count > 0)
            {
                SecilenDosyaNo = dgvHastalar.SelectedRows[0].Cells["DosyaNo"].Value?.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
