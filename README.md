🌍 TekBaşımaCoreProje1 – ASP.NET Core MVC Web Projesi
Bu proje, ASP.NET Core MVC ile hazırlanmış çok sayfalı bir web uygulamasıdır. Her şehir için ayrı controller ve view’lar tanımlanmış, ViewComponent kullanımıyla modüler yapı oluşturulmuştur. Proje, şehirler arası içerik yönetimi ve gösterimi odaklıdır.

🧱 Proje Yapısı:
📂 Controllers
Her şehir için bir controller var:

AnkaraController.cs, BatmanController.cs, KonyaController.cs, İstanbulController.cs, ŞanlıurfaController.cs: Her biri ilgili şehre ait sayfa işlemlerini kontrol eder.

HomeController.cs: Ana sayfa işlevlerini içerir.

📂 Models
Veri modelleri burada tanımlıdır:

ArvesoftVeriTanımlama.cs, ArvesoftVeriİçerik.cs: İçerik veri yapısını tanımlar.

VeriTipleriTanımlamaModeli.cs, Yeni.cs, yeniİçerik.cs: Ek içerik ve tanımlamalar.

VeriContext(icerik).cs: Veritabanı bağlantısı için kullanılan DbContext sınıfıdır (muhtemelen EF Core).

ErrorViewModel.cs: Hata yönetimi için model.

📂 ViewComponents
Sayfalarda tekrar kullanılabilecek bileşenler:

Ankarailetişim.cs, Batmaniletişim.cs, Konyailetişim.cs, istanbuliletişim.cs, Şanlıurfailetişim.cs: Her şehre ait iletişim bileşenleri.

meslekler.cs, sehirler.cs: Ortak bileşenler olabilir.

📂 Views
Razor View dosyaları:

Şehir isimlerine göre (Ankara, Batman, Konya, İstanbul, Şanlıurfa) özel sayfa görünümleri var.

Shared/: Ortak görünümler (_Layout.cshtml, _ValidationScriptsPartial.cshtml, Error.cshtml).

Components/: ViewComponent’lere ait Razor view dosyaları.

_ViewImports.cshtml, _ViewStart.cshtml: Razor için temel yapı dosyaları.

📂 wwwroot
Statik dosyalar (CSS, JS, görseller) burada yer alır.

🧠 Yapılandırmalar
Startup.cs: Middleware ve servis yapılandırmaları burada.

Program.cs: Uygulama giriş noktası.

appsettings.json, appsettings.Development.json: Veritabanı bağlantısı gibi yapılandırma değerleri.

launchSettings.json: Debug ayarları.

📦 Genel Proje Özellikleri:
🌐 Şehir bazlı sayfalar (Ankara, Batman, Konya vb.)

🧩 ViewComponent ile modüler yapı.

🗃️ Entity Framework Core ile veri yönetimi (muhtemelen içerik çekme ve kaydetme).

📄 Razor View ile sayfa oluşturma.

⚙️ MVC mimarisiyle sayfa kontrolü, veri modeli ve görünüm ayrımı.
