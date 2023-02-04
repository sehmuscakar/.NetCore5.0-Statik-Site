using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TekBaşımaCoreProje1.Models
{
    public class ArvesoftVeriİçerik
    {
        public static List<ArvesoftVeriTanımlama> istanbulveriler = new()
        {
            new ArvesoftVeriTanımlama { ID= 1, Adı = "Murat", Soyadı = "Kara", Kıdemi= "Mid-Level", Görevi=".Net Core Developer",Yaşı=35 },
            new ArvesoftVeriTanımlama { ID = 2, Adı = "Akın", Soyadı = "Toprak", Kıdemi = "Senior", Görevi = ".Net Framwork Developer", Yaşı = 30 },
            new ArvesoftVeriTanımlama { ID = 3, Adı = "Yavuz", Soyadı = "Açık", Kıdemi = "Junior", Görevi = ".Net Developer", Yaşı = 39 },
            new ArvesoftVeriTanımlama { ID = 4, Adı = "Mert", Soyadı = "Taş", Kıdemi = "Junior", Görevi = "Devexpress Developer", Yaşı = 28},
            new ArvesoftVeriTanımlama { ID = 5, Adı = "Ayşe", Soyadı = "Kağıt", Kıdemi = "Senior", Görevi = "WinForms Developer", Yaşı = 32},
            new ArvesoftVeriTanımlama { ID = 6, Adı = "Fatma", Soyadı = "Demir", Kıdemi = "Mid-Level", Görevi = "Mobile Developer", Yaşı = 35},
            new ArvesoftVeriTanımlama { ID = 7, Adı = "Berfin", Soyadı = "Çelik", Kıdemi = "Senior", Görevi = "Mobile Developer", Yaşı = 40},
            new ArvesoftVeriTanımlama { ID = 8, Adı = "Yavuz", Soyadı = "Bakır", Kıdemi = "Mid-Level", Görevi = ".Net Framwork Developer", Yaşı = 44 },
            new ArvesoftVeriTanımlama { ID = 9, Adı = "Zeynep", Soyadı = "Kağıt", Kıdemi = "Senior", Görevi = ".Net Framwork Developer ", Yaşı = 32 },
            new ArvesoftVeriTanımlama { ID = 10, Adı = "Serdar", Soyadı = "Demir", Kıdemi = "Senior", Görevi = ".Net Core Developer", Yaşı = 26 },

        };

        public static List<ArvesoftVeriTanımlama> ankaraveriler = new()
        {
            new ArvesoftVeriTanımlama { ID = 1, Adı = "Ali", Soyadı = "Bakır", Kıdemi = "Junior", Görevi = "Siber Güvenlik", Yaşı = 35},
            new ArvesoftVeriTanımlama {ID = 2, Adı = "Serhat", Soyadı = "Beyaz", Kıdemi = "Senior", Görevi = "PHP Developer", Yaşı = 45 },
            new ArvesoftVeriTanımlama {ID = 3, Adı = "Serdar", Soyadı = "Akıcı", Kıdemi = "Junior", Görevi = ".Net Core Developer", Yaşı = 26 },
            new ArvesoftVeriTanımlama {ID = 4, Adı = "Kemal", Soyadı = "Hava", Kıdemi = "Senior", Görevi = ".Net FramworkDeveloper", Yaşı = 39 },
            new ArvesoftVeriTanımlama {ID = 5, Adı = "Mazlum", Soyadı = "Kızmaz", Kıdemi = "Mid-Level", Görevi = ".Net Framwork Developer", Yaşı = 29 },
            new ArvesoftVeriTanımlama {ID = 6, Adı = "Akif", Soyadı = "Çelik", Kıdemi = "Junior", Görevi = "Mobile Developer", Yaşı = 27 },
            new ArvesoftVeriTanımlama {ID = 7, Adı = "Yavuz", Soyadı = "Demir", Kıdemi = "Junior", Görevi = "Mobile Developer", Yaşı = 25 },
            new ArvesoftVeriTanımlama {ID = 8, Adı = "Selim", Soyadı = "Can", Kıdemi = "Senior", Görevi = ".Net Framwork Developer", Yaşı = 47 },
            new ArvesoftVeriTanımlama {ID = 9, Adı = "Cemal", Soyadı = "Çakar", Kıdemi = "Mid-Level", Görevi = ".Net Core Developer", Yaşı = 36 },
            new ArvesoftVeriTanımlama {ID = 10, Adı = "Zeynep", Soyadı = "Akın", Kıdemi = "Junior", Görevi = "Mobile Developer", Yaşı = 24 },
            new ArvesoftVeriTanımlama { ID = 11 ,Adı = "Cemile", Soyadı = "Demir", Kıdemi = "Junior", Görevi = ".Net Core Developer", Yaşı = 27 },
            new ArvesoftVeriTanımlama { ID = 12,Adı = "Zehra", Soyadı = "Kağıt", Kıdemi = "Senior", Görevi = ".Net Core Developer ", Yaşı = 30 },

        };

        public static List<ArvesoftVeriTanımlama> konyaveriler = new()
        {
            new ArvesoftVeriTanımlama { ID = 1, Adı = "Aylin", Soyadı = "Çiçek", Kıdemi = "Mid-Level", Görevi = ".Net Developer", Yaşı = 26 },
            new ArvesoftVeriTanımlama {ID = 2, Adı = "Mehmet", Soyadı = "Demir", Kıdemi = "Senior", Görevi = ".Net Core Developer", Yaşı = 36 },
            new ArvesoftVeriTanımlama {ID = 3, Adı = "Ali", Soyadı = "Duman", Kıdemi = "Junior", Görevi = ".Net Framwork Developer", Yaşı = 22 },
            new ArvesoftVeriTanımlama {ID = 4, Adı = "Halide", Soyadı = "Çilek", Kıdemi = "Junior", Görevi = "WinForms Developer", Yaşı = 25 },
            new ArvesoftVeriTanımlama {ID = 5, Adı = "Hüseyin", Soyadı = "Çelik", Kıdemi = "Senior", Görevi = ".Net Core Developer", Yaşı = 45 },
            new ArvesoftVeriTanımlama {ID = 6, Adı = "Hatice", Soyadı = "Kara", Kıdemi = "Mid-Level", Görevi = "Siber Güvenlik Developer", Yaşı = 38 },
            new ArvesoftVeriTanımlama {ID = 7, Adı = "Mustafa", Soyadı = "Akın", Kıdemi = "Mid-Level", Görevi = "Mobile Developer", Yaşı = 30 },
            new ArvesoftVeriTanımlama {ID = 8, Adı = "Murat", Soyadı = "Açık", Kıdemi = "Junior", Görevi = ".Net Framwork Developer", Yaşı = 24},
            new ArvesoftVeriTanımlama {ID = 9, Adı = "Yavuz", Soyadı = "Çatı", Kıdemi = "Senior", Görevi = "Siber Güvenlik Developer", Yaşı = 42 },
                                      
        };
        public static List<ArvesoftVeriTanımlama> şanlıurfaveriler = new()
        {
            new ArvesoftVeriTanımlama { ID = 1, Adı = "Halit", Soyadı = "Demir", Kıdemi = "Senior", Görevi = "Winforms Developer", Yaşı = 35 },
            new ArvesoftVeriTanımlama {ID = 2, Adı = "Hüseyin", Soyadı = "Celik", Kıdemi = "Senior", Görevi = ".Net Core Developer", Yaşı = 45 },
            new ArvesoftVeriTanımlama {ID = 3, Adı = "Mustafa", Soyadı = "Akın", Kıdemi = "Mid-Level", Görevi = "Mobile Developer", Yaşı = 30 },
            new ArvesoftVeriTanımlama {ID = 4, Adı = "Selim", Soyadı = "Demir", Kıdemi = "Senior", Görevi = ".Net Framwork Developer", Yaşı = 47 },
            new ArvesoftVeriTanımlama {ID = 5, Adı = "Zeynep", Soyadı = "Kağıt", Kıdemi = "Senior", Görevi = ".Net Framwork Developer ", Yaşı = 32 },
            new ArvesoftVeriTanımlama {ID = 6, Adı = "Serdar", Soyadı = "Akıcı", Kıdemi = "Mid-Level", Görevi = ".Net Core Developer", Yaşı = 26 },
            new ArvesoftVeriTanımlama {ID = 7, Adı = "Kenan", Soyadı = "Hava", Kıdemi = "Mid-Level", Görevi = ".Net FramworkDeveloper", Yaşı = 35 },
            new ArvesoftVeriTanımlama {ID = 8, Adı = "Mazlum", Soyadı = "Kızmaz", Kıdemi = "Senior", Görevi = ".Net Framwork Developer", Yaşı = 30 },
                                     
        };                            
        public static List<ArvesoftVeriTanımlama> batmanveriler = new()
        {
            new ArvesoftVeriTanımlama { ID = 1, Adı = "Şehmus", Soyadı = "Çakar", Kıdemi = "Junior", Görevi = ".Net Core Developer", Yaşı = 22 },
            new ArvesoftVeriTanımlama {ID = 2, Adı = "Akif", Soyadı = "Akın", Kıdemi = "Junior", Görevi = "Mobile Developer", Yaşı = 26 },
            new ArvesoftVeriTanımlama {ID = 3, Adı = "Vedat", Soyadı = "Çelik", Kıdemi = "Senior", Görevi = "WinForms Developer", Yaşı = 36 },
            new ArvesoftVeriTanımlama {ID = 4, Adı = "Yavuz", Soyadı = "Akın", Kıdemi = "Mid-Level", Görevi = "Siber Güvenlik Developer", Yaşı = 42 },
            new ArvesoftVeriTanımlama {ID = 5, Adı = "Mert", Soyadı = "Taş", Kıdemi = "Junior", Görevi = "Devexpress Developer", Yaşı = 28 },
            new ArvesoftVeriTanımlama {ID = 6, Adı = "Ayşe", Soyadı = "Akıl", Kıdemi = "Mid-Level", Görevi = "WinForms Developer", Yaşı = 35 },
            new ArvesoftVeriTanımlama {ID = 7, Adı = "Fatma", Soyadı = "Demir", Kıdemi = "Mid-Level", Görevi = "Mobile Developer", Yaşı = 35 },
            new ArvesoftVeriTanımlama {ID = 8, Adı = "Hüseyin", Soyadı = "Bakır", Kıdemi = "Senior", Görevi = ".Net Core Developer", Yaşı = 42 },
            new ArvesoftVeriTanımlama {ID = 9, Adı = "Hatice", Soyadı = "Kara", Kıdemi = "Mid-Level", Görevi = "Siber Güvenlik Developer", Yaşı = 30 },
            new ArvesoftVeriTanımlama {ID = 10,Adı = "Alican", Soyadı = "Demir", Kıdemi = "Mid-Level", Görevi = "Mobile Developer", Yaşı = 30 },

        };
    }
}
