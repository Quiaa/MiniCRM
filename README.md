# Mini CRM - Satış Aktivite Takip Uygulaması

Bu proje, bir teknik değerlendirme çalışması kapsamında; satış temsilcilerinin firma ve görüşme kayıtlarını yönetebilmesi amacıyla geliştirilmiştir.

## 🛠 Kullanılan Teknolojiler
* **Framework:** ASP.NET MVC 5 (.NET Framework 4.8)
* **ORM:** Entity Framework 6 (Code First Yaklaşımı)
* **Veritabanı:** MS SQL Server (LocalDB)
* **Arayüz:** Bootstrap 5, HTML5, CSS3
* **Diğer:** jQuery Validation

## 🚀 Proje Özellikleri
* **Firma Yönetimi:** Firma ekleme, düzenleme, silme ve listeleme.
* **Görüşme Yönetimi:** Firmalarla yapılan görüşmelerin takibi.
* **Dashboard:** Toplam firma ve görüşme sayılarını içeren özet ekran.
* **İlişkisel Yapı:** Firma detay sayfasında, o firmaya ait geçmiş görüşmelerin listelenmesi.
* **Kullanıcı Deneyimi:** Tarih seçiciler (Datepicker) ve Türkçe arayüz.

## ⚙️ Kurulum ve Çalıştırma Adımları
1.  Projeyi klonlayın veya zip olarak indirin.
2.  `MiniCRMApp.sln` dosyasını Visual Studio ile açın.
3.  **Web.config** dosyasındaki `connectionStrings` ayarının yerel SQL sunucunuza uygun olduğundan emin olun (Varsayılan: MSSQLLocalDB).
4.  **Package Manager Console**'u açın (Tools > NuGet Package Manager > Package Manager Console).
5.  Veritabanını oluşturmak için şu komutu çalıştırın:
    ```powershell
    Update-Database
    ```
6.  Projeyi `Ctrl + F5` ile çalıştırın.

## Ekran Görüntüleri

<img width="1157" height="604" alt="image" src="https://github.com/user-attachments/assets/ade674a1-6696-4183-a244-cfe5c474121a" />
<img width="1262" height="398" alt="image" src="https://github.com/user-attachments/assets/21796f58-6a51-4319-a87a-7bf93f274389" />
<img width="1310" height="351" alt="image" src="https://github.com/user-attachments/assets/92d696d0-b8bc-44b3-ab4f-6ed19565f44a" />

<img width="1320" height="605" alt="image" src="https://github.com/user-attachments/assets/f6a8be9b-0074-4aec-890c-42f3fc85b7a1" />

## 🔮 Geliştirilmesi Planlanan Noktalar (Future Work)
Proje kapsamı ve süresi dahilinde temel gereksinimler karşılanmıştır. İlerleyen aşamalarda eklenebilecek özellikler:
* **Yetkilendirme (Auth):** ASP.NET Identity ile kullanıcı giriş/çıkış sistemi ve rol yönetimi (Satışçı/Yönetici).
* **Filtreleme:** Firma ve görüşme listelerinde detaylı arama ve filtreleme seçenekleri.
* **Raporlama:** Görüşme türlerine göre grafiksel raporlar.
* **Export:** Listelerin Excel/PDF formatında dışa aktarılması.

---
*Bu proje staj değerlendirme case'i için hazırlanmıştır.*
