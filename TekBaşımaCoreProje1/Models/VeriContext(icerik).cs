using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TekBaşımaCoreProje1.Models
{
    public class VeriContext_icerik_
    {
        public static List<VeriTipleriTanımlamaModeli> veriTipleriTanımlamaModelis = new()//burda VeriTipleriTanımlamaModeli ndekileri liste şeklinde tanımladık ve bu listeden bir nesne türetik
        //bu nesne sayesinde controller kısmında verileri control edebilecez ,bu nesne Veri_Context_İçerik_ sınıfının nesnesi
        {
            new VeriTipleriTanımlamaModeli {ID=1,Proje="Batman Eğitim Araştırma Hastanesi Randevu Sistemi",Sehir="Batman",Ücret=15000},
            new VeriTipleriTanımlamaModeli {ID=2,Proje="Petrol City AVM Yazılım Bağlantı Sistemi ",Sehir="Batman",Ücret=1000},
            new VeriTipleriTanımlamaModeli {ID=3,Proje="Mevsim ET Lokantası Adisyon Sistemi",Sehir="Ankara",Ücret=7000},
            new VeriTipleriTanımlamaModeli {ID=4,Proje="Lezet Lokantası Barkod Sistemi",Sehir="İstanbul",Ücret=5000},
            new VeriTipleriTanımlamaModeli {ID=5,Proje="Mersin Büyükşehir Beledyesi Yazılım Altyapısı",Sehir="Mersin",Ücret=30000},
            new VeriTipleriTanımlamaModeli {ID=6,Proje="Adana Emniyet Müdürlüğü Siber Gövenlik Testi Uygulaması",Sehir="Adana",Ücret=15000},
            new VeriTipleriTanımlamaModeli {ID=7,Proje="Diyarbakır Künefe Adisyon Sistemi",Sehir="Diyarbakır",Ücret=5000},
            new VeriTipleriTanımlamaModeli {ID=8,Proje="Karadeniz Teknik Üniversitesi Web Tabanlı Öğrenci Kayıt Uygulaması",Sehir="Trabzon",Ücret=10000},
            new VeriTipleriTanımlamaModeli {ID=9,Proje="Bağcılar Izgara Salonu Adisyon Sistemi",Sehir="İstanbul",Ücret=8000},
            new VeriTipleriTanımlamaModeli {ID=10,Proje="ODTÜ Yazılım Altyapısı",Sehir="Ankara",Ücret=45000},
            new VeriTipleriTanımlamaModeli {ID=12,Proje="İzmir Büyükşehir Belediyesi Yazılım Altyapısı",Sehir="İzmir",Ücret=38000},
            new VeriTipleriTanımlamaModeli {ID=13,Proje="Kendime Izgara Salonu Barkod Sistemi ",Sehir="Batman",Ücret=9000},
           
       

        };

       
    }
}
