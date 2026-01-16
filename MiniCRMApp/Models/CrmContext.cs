using System.Data.Entity; // Entity Framework kütüphanesi

namespace MiniCRMApp.Models
{
    // "Veritabanı Yöneticisi"
    public class CrmContext : DbContext
    {
        // "base" kısmı önemli. Web.config dosyasında "CrmConnection" adında bir ayar arayacak.
        public CrmContext() : base("name=CrmConnection")
        {
        }

        // Veritabanında "Companies" adında bir tablo oluştur ve Company modelini kullan.
        public DbSet<Company> Companies { get; set; }

        // Veritabanında "Meetings" adında bir tablo oluştur ve Meeting modelini kullan.
        public DbSet<Meeting> Meetings { get; set; }
    }
}