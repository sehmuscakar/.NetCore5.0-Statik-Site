using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TekBaşımaCoreProje1.Models
{
    public class ArvesoftVeriTanımlama
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        [MaxLength(30, ErrorMessage = "Ad alanı en fazla 30 karekter olabilir")]
        [MinLength(3, ErrorMessage = "Ad alanı en az 3 karekter olmalı")]
        public string Adı { get; set; }
        [Required(ErrorMessage = "Soyad alanı boş geçilemez")]
        [MaxLength(30, ErrorMessage = "Soyad alanı en fazla 30 karekter olabilir")]
        [MinLength(3, ErrorMessage = "Soyad alanı en az 3 karekter olmalı")]
        public string Soyadı { get; set; }
        [Required(ErrorMessage = "Kıdem alanı boş geçilemez")]
      
        public string Kıdemi { get; set; }
        [Required(ErrorMessage = "Görev alanı boş geçilemez")]
        public string Görevi { get; set; }
        [Range(16, 45, ErrorMessage = "yaş değeri en az 16 ,en fazla 45 olabilir")]
        public int Yaşı { get; set; }
       
    }
}
