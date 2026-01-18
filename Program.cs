using System;
using System.Windows.Forms;

namespace SOHATS
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana giriş noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Veritabanını başlat (yoksa oluştur, tabloları ve admin'i ekle)
            DatabaseHelper.InitializeDatabase();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Login formu ile başla
            Application.Run(new LoginForm());
        }
    }
}
