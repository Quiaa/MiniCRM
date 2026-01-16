using System;
using System.Collections.Generic;
using System.ComponentModel; 
using System.ComponentModel.DataAnnotations;

namespace MiniCRMApp.Models
{
    public class Company
    {
        // Veritabanındaki birincil anahtar (Primary Key)
        public int Id { get; set; }

        [DisplayName("Firma Adı")] // Ekranda görünecek isim
        [Required(ErrorMessage = "Firma adı boş bırakılamaz.")] // Boş geçilemez kuralı
        public string Name { get; set; }

        [DisplayName("Yetkili Kişi")]
        public string ContactPerson { get; set; }

        [DisplayName("Telefon")]
        public string Phone { get; set; }

        [DisplayName("E-posta")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta giriniz.")] // E-posta formatı kontrolü
        public string Email { get; set; }

        [DisplayName("Oluşturulma Tarihi")]
        public DateTime CreatedDate { get; set; } = DateTime.Now; // Varsayılan olarak şu anın tarihi.

        // İLİŞKİ: Bir firmanın birden çok görüşmesi olabilir.
        // "virtual" kelimesi Entity Framework'ün bu ilişkiyi anlaması için.
        public virtual ICollection<Meeting> Meetings { get; set; }
    }
}