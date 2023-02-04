using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TekBaşımaCoreProje1.Models;

namespace TekBaşımaCoreProje1.ViewComponents
{
    public class Konyailetişim:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var konyailetişim = yeniİçerik.Konyailetişim;
            return View(konyailetişim);
        }
    }
}
