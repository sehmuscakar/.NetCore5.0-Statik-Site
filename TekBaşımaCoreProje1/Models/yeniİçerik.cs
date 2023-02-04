using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TekBaşımaCoreProje1.Models
{
    public class yeniİçerik
    {
        public static List<Yeni> List = new()
        {
            new Yeni { Meslek = "Yazılım Uzmanılarımız" },
            new Yeni { Meslek = "IT Uzmanılarımız" },
            new Yeni { Meslek = "Mühendislerimiz" },
            new Yeni { Meslek = "Teknikerlerimiz" },
            new Yeni { Meslek = "Teknisyenlerimiz" },
            new Yeni { Meslek = "Stajyerlerimiz" },

        };

        public static List<Yeni> Liste = new()
        {
            new Yeni { sehirler= "ANKARA" },
            new Yeni { sehirler= "AFYONKARAHİSAR" },
            new Yeni { sehirler= "BİLECİK" },
            new Yeni { sehirler= "BİTLİS" },
            new Yeni { sehirler= "SİİRT" },
            new Yeni { sehirler= "VAN" },
            new Yeni { sehirler= "ZONGULDAK" },
            new Yeni { sehirler= "BATMAN"},
            new Yeni { sehirler= "ARDAHAN" },
            new Yeni { sehirler= "BALIKESİR"},
            new Yeni { sehirler= "OSMANİYE" },
            new Yeni { sehirler= "MARDİN" },
            new Yeni { sehirler= "MUŞ" },
            new Yeni { sehirler= "NEVŞEHİR" },
            new Yeni { sehirler="Erzurum"},
            new Yeni { sehirler= "NİĞDE" },
            new Yeni { sehirler= "RİZE" },
            new Yeni { sehirler= "SAMSUN" },
            new Yeni { sehirler= "SAMSUN" },
            new Yeni { sehirler= "İSTANBUL" },
            new Yeni { sehirler= "İZMİR" },
            new Yeni { sehirler= "MERSİN"},
            new Yeni { sehirler= "DİYARBAKIR" },
            new Yeni { sehirler= "ADANA"},
            new Yeni { sehirler= "ELAZIĞ" },
            new Yeni { sehirler= "GAZİANTEP" },
            new Yeni { sehirler= "GİRESUN" },
            new Yeni { sehirler= "HAKKARİ" },
        };

        public static List<Yeni> Ankarailetişim = new()
        {
            new Yeni { Telefon="0542-582-7272"},
            new Yeni { Email="merhaba@arvesoft.com"},
        };

        public static List<Yeni> İstanbuliletişim = new()
        {
            new Yeni { Telefon = "0545-400-2020" },
            new Yeni { Email = "istanbul@arvesoft.com" },
        };
        public static List<Yeni> Konyailetişim = new()
        {
            new Yeni { Telefon = "0546-422-8870" },
            new Yeni { Email = "konya@arvesoft.com" },
        };
        public static List<Yeni> Şanlıurfailetişim = new()
        {
            new Yeni { Telefon = "0543-598-0899" },
            new Yeni { Email = "sanlıurfa@arvesoft.com" },
        };
        public static List<Yeni> Batmaniletişim = new()
        {
            new Yeni { Telefon = "0542-582-72-72" },
            new Yeni { Email = "batman@arvesoft.com" },
        };

    }
}
