using System;

namespace SOHATS
{
    /// <summary>
    /// Oturum açmış kullanıcının bilgilerini tutan statik sınıf.
    /// Menü ve yetki kontrollerinde kullanılır.
    /// </summary>
    public static class CurrentUser
    {
        public static int KullaniciKodu { get; set; }
        public static string Ad { get; set; }
        public static string Soyad { get; set; }
        public static string Yetki { get; set; } // "Yonetici" veya "Personel"
        public static string Durum { get; set; }

        public static bool IsAdmin => Yetki == "Yonetici";
        public static bool IsLoggedIn => KullaniciKodu > 0;

        public static void Clear()
        {
            KullaniciKodu = 0;
            Ad = null;
            Soyad = null;
            Yetki = null;
            Durum = null;
        }
    }
}
