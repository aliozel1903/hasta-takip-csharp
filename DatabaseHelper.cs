using System;
using System.IO;
using Microsoft.Data.Sqlite;

namespace SOHATS
{
    public static class DatabaseHelper
    {
        private const string DbFileName = "SOHATS.db";
        public static string ConnectionString => $"Data Source={DbFileName}";

        /// <summary>
        /// Program başlangıcında çağırılmalı. Veritabanı yoksa oluşturur,
        /// tabloları yaratır ve varsayılan admin kullanıcısını ekler.
        /// </summary>
        public static void InitializeDatabase()
        {
            bool isNewDatabase = !File.Exists(DbFileName);

            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                CreateTables(connection);

                if (isNewDatabase)
                {
                    InsertDefaultAdmin(connection);
                    Console.WriteLine("SOHATS.db dosyası ve varsayılan admin kullanıcısı oluşturuldu.");
                }
            }
        }

        private static void CreateTables(SqliteConnection connection)
        {
            using (var command = connection.CreateCommand())
            {
                // 1. Kullanici Tablosu
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Kullanici (
                        KullaniciKodu INTEGER PRIMARY KEY AUTOINCREMENT,
                        Ad TEXT NOT NULL,
                        Soyad TEXT NOT NULL,
                        Sifre TEXT NOT NULL,
                        Yetki TEXT NOT NULL,
                        Durum TEXT NOT NULL
                    );";
                command.ExecuteNonQuery();

                // 2. Poliklinik Tablosu
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Poliklinik (
                        PoliklinikID INTEGER PRIMARY KEY AUTOINCREMENT,
                        PoliklinikAdi TEXT NOT NULL,
                        Durum TEXT NOT NULL
                    );";
                command.ExecuteNonQuery();

                // 3. Doktor Tablosu
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Doktor (
                        DoktorKodu TEXT PRIMARY KEY,
                        Ad TEXT NOT NULL,
                        Soyad TEXT NOT NULL,
                        Unvan TEXT,
                        Durum TEXT NOT NULL
                    );";
                command.ExecuteNonQuery();

                // 4. Hasta Tablosu
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Hasta (
                        DosyaNo TEXT PRIMARY KEY,
                        TCNo TEXT UNIQUE,
                        Ad TEXT NOT NULL,
                        Soyad TEXT NOT NULL,
                        DogumYeri TEXT,
                        DogumTarihi TEXT,
                        BabaAdi TEXT,
                        AnaAdi TEXT,
                        Cinsiyet TEXT,
                        KurumAdi TEXT
                    );";
                command.ExecuteNonQuery();

                // 5. Sevk Tablosu (Composite Primary Key)
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Sevk (
                        DosyaNo TEXT,
                        SevkTarihi TEXT,
                        Saat TEXT,
                        DrKodu TEXT,
                        Miktar INTEGER,
                        BirimFiyat REAL,
                        ToplamTutar REAL,
                        Taburcu INTEGER DEFAULT 0,
                        PRIMARY KEY (DosyaNo, SevkTarihi),
                        FOREIGN KEY (DosyaNo) REFERENCES Hasta(DosyaNo)
                    );";
                command.ExecuteNonQuery();

                // 6. Islem Tablosu (FK to Sevk)
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Islem (
                        IslemID INTEGER PRIMARY KEY AUTOINCREMENT,
                        DosyaNo TEXT,
                        SevkTarihi TEXT,
                        IslemAdi TEXT,
                        DrKodu TEXT,
                        Miktar INTEGER,
                        BirimFiyat REAL,
                        FOREIGN KEY (DosyaNo, SevkTarihi) REFERENCES Sevk(DosyaNo, SevkTarihi)
                    );";
                command.ExecuteNonQuery();

                Console.WriteLine("Tablolar başarıyla oluşturuldu.");
            }
        }

        private static void InsertDefaultAdmin(SqliteConnection connection)
        {
            using (var command = connection.CreateCommand())
            {
                // Varsayılan admin kullanıcısı
                command.CommandText = @"
                    INSERT INTO Kullanici (Ad, Soyad, Sifre, Yetki, Durum)
                    VALUES (@Ad, @Soyad, @Sifre, @Yetki, @Durum);";
                
                command.Parameters.AddWithValue("@Ad", "admin");
                command.Parameters.AddWithValue("@Soyad", "admin");
                command.Parameters.AddWithValue("@Sifre", "admin123");
                command.Parameters.AddWithValue("@Yetki", "Yonetici");
                command.Parameters.AddWithValue("@Durum", "Aktif");

                command.ExecuteNonQuery();
            }

            InsertSampleData(connection);
        }

        private static void InsertSampleData(SqliteConnection connection)
        {
            using (var command = connection.CreateCommand())
            {
                // Örnek Kullanıcı
                command.CommandText = @"INSERT INTO Kullanici (Ad, Soyad, Sifre, Yetki, Durum) VALUES 
                    ('zeynep', 'Kaya', '1234', 'Personel', 'Aktif');";
                command.ExecuteNonQuery();

                // Örnek Poliklinikler
                command.CommandText = @"INSERT INTO Poliklinik (PoliklinikAdi, Durum) VALUES 
                    ('Dahiliye', 'Gecerli'),
                    ('Pediatri', 'Gecerli'),
                    ('Ortopedi', 'Gecerli'),
                    ('Kardiyoloji', 'Gecerli');";
                command.ExecuteNonQuery();

                // Örnek Doktorlar
                command.CommandText = @"INSERT INTO Doktor (DoktorKodu, Ad, Soyad, Unvan, Durum) VALUES 
                    ('DR001', 'Ahmet', 'Yılmaz', 'Dr.', 'Aktif'),
                    ('DR002', 'Fatma', 'Demir', 'Uzm. Dr.', 'Aktif'),
                    ('DR003', 'Mehmet', 'Öztürk', 'Prof. Dr.', 'Aktif');";
                command.ExecuteNonQuery();

                // Örnek Hastalar
                command.CommandText = @"INSERT INTO Hasta (DosyaNo, TCNo, Ad, Soyad, DogumYeri, DogumTarihi, BabaAdi, AnaAdi, Cinsiyet, KurumAdi) VALUES 
                    ('H001', '12345678901', 'Ali', 'Veli', 'Ankara', '1985-03-15', 'Hasan', 'Ayşe', 'Erkek', 'SGK'),
                    ('H002', '98765432109', 'Merve', 'Şahin', 'İstanbul', '1990-07-22', 'Kemal', 'Zehra', 'Kadın', 'SGK'),
                    ('H003', '11122233344', 'Emre', 'Koç', 'İzmir', '1978-11-05', 'Osman', 'Fatma', 'Erkek', 'Özel');";
                command.ExecuteNonQuery();

                // Örnek Sevkler
                command.CommandText = @"INSERT INTO Sevk (DosyaNo, SevkTarihi, Saat, DrKodu, Miktar, BirimFiyat, ToplamTutar, Taburcu) VALUES 
                    ('H001', '2024-12-20', '09:30', 'DR001', 1, 100.00, 100.00, 1),
                    ('H002', '2024-12-22', '14:00', 'DR002', 1, 150.00, 150.00, 0),
                    ('H003', '2024-12-25', '10:15', 'DR001', 1, 100.00, 100.00, 0);";
                command.ExecuteNonQuery();

                Console.WriteLine("Örnek veriler eklendi.");
            }
        }
    }
}
