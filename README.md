# SOHATS - Sağlık Ocağı Hasta Takip Sistemi

SOHATS, C# ve .NET teknolojileri kullanılarak geliştirilmiş, sağlık ocakları için tasarlanmış kapsamlı bir hasta takip ve yönetim otomasyonudur. Bu proje, **Nesne Yönelimli Programlama (OOP)** prensiplerine uygun olarak, **MDI (Multiple Document Interface)** form yapısında ve **SQLite** veritabanı mimarisi kullanılarak geliştirilmiştir.

## 🚀 Özellikler

* **Kullanıcı Yetkilendirme Sistemi:**
    * Yönetici ve Personel olmak üzere rol bazlı giriş sistemi.
    * Yetkiye göre dinamik menü yönetimi (Örn: Sadece yöneticiler referans tanımlarına erişebilir).
* **Hasta Kabul Modülü:**
    * Yeni hasta kaydı oluşturma, hasta arama ve güncelleme işlemleri.
    * TC Kimlik No ve Dosya No bazlı takip.
* **Poliklinik ve Doktor Yönetimi:**
    * Dinamik poliklinik ve doktor tanımlama ekranları.
    * Doktor ve branş eşleştirmeleri.
* **Raporlama:**
    * Hasta ve işlem bazlı raporlamalar.
* **Veritabanı Yönetimi:**
    * SQLite ile gömülü (embedded) veritabanı yapısı.
    * Otomatik veritabanı ve tablo kurulumu (Code-First yaklaşımına benzer yapı).

## 🛠️ Teknolojiler ve Araçlar

* **Dil:** C# (.NET 8.0 Windows Forms)
* **Veritabanı:** SQLite (`Microsoft.Data.Sqlite`)
* **IDE:** Visual Studio 2022
* **Mimari:** Katmanlı Mimarisi (Data Access Logic ayrımı)

## 📂 Proje Yapısı

* **DatabaseHelper.cs:** Veritabanı bağlantısı, tablo oluşturma (DDL) ve tohum verilerin (Seed Data) yönetimini sağlayan statik sınıf.
* **CurrentUser.cs:** Oturum süresince aktif kullanıcının bilgilerini ve yetkilerini tutan statik sınıf.
* **MainForm (MDI):** Uygulamanın ana çatısı, tüm alt formların yönetildiği merkez.

## 📸 Ekran Görüntüleri

<img width="483" height="346" alt="Giriş Ekranı" src="https://github.com/user-attachments/assets/768ea41d-20f3-4715-bf5e-db73bc5b8e56" />
<img width="800" alt="Hasta Kayıt" src="https://github.com/user-attachments/assets/74d133d0-a39f-4c35-b68c-045b2947790c" />

## 📦 Kurulum

1. Projeyi klonlayın:
   ```bash
   git clone [https://github.com/aliozel1903/hasta-takip-csharp.git](https://github.com/aliozel1903/hasta-takip-csharp.git)

2. Visual Studio ile SOHATS.sln dosyasını açın.

3. Projeyi derleyin ve çalıştırın. (Gerekli veritabanı dosyası SOHATS.db otomatik olarak oluşturulacaktır.)

Varsayılan Giriş Bilgileri:

Kullanıcı Adı: admin

Şifre: admin123
