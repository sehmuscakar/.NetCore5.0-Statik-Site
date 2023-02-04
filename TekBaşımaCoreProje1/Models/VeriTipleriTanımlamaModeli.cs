using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TekBaşımaCoreProje1.Models
{
    public class VeriTipleriTanımlamaModeli
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Proje ismi boş geçilemez")]
        public string Proje { get; set; }
           [Required(ErrorMessage ="Şehir alanı boş geçilemez")]
        [MaxLength(30,ErrorMessage ="Şehir alanı en fazla 30 karekter olabilir")]
        [MinLength(3, ErrorMessage = "Şehiralanı en az 3 karekter olmalı")]
        public string Sehir { get; set; }
        [Required(ErrorMessage = "Proje ismi boş geçilemez")]
        [Range(0,10000,ErrorMessage ="Ücret Alanı boş en az 0 TL,En fazla 10000 TL olabilir")]
        public int Ücret { get; set; }
    
    }
}
