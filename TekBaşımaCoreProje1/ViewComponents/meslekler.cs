using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TekBaşımaCoreProje1.Models;

namespace TekBaşımaCoreProje1.ViewComponents
{
    public class meslekler: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var list = yeniİçerik.List;//burda yeniiçerik sınıfının Liste nesnesine ulaştık
                return View(list);

         
        }



    }
}
