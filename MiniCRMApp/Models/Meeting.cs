using MiniCRMApp.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MiniCRMApp.Models
{
    public class Meeting
    {
        public int Id { get; set; }

        [DisplayName("Görüşme Tarihi")]
        [Required]
        // Ekranda sadece tarih ve saati düzgün seçtirmek için format
        [DataType(DataType.DateTime)]
        public DateTime MeetingDate { get; set; } = DateTime.Now;

        [DisplayName("Görüşme Notu")]
        [DataType(DataType.MultilineText)] // Ekranda büyük kutucuk (textarea) olsun diye
        public string Note { get; set; }

        [DisplayName("Görüşme Türü")]
        // Basit olsun diye şimdilik metin tutuyoruz.
        public string MeetingType { get; set; }

        [DisplayName("Sonraki Aksiyon Tarihi")]
        // Soru işareti (?) bu alanın "Boş bırakılabilir" (Nullable) olduğunu söyler.
        public DateTime? NextActionDate { get; set; }

        // İLİŞKİ: Bu görüşme kime ait?
        // Bu bir "Yabancı Anahtar" (Foreign Key).
        [DisplayName("Firma")]
        public int CompanyId { get; set; }

        // Bu da kod içinde firmaya kolayca ulaşmak için (Company.Name diyebilmek için)
        public virtual Company Company { get; set; }
    }
}