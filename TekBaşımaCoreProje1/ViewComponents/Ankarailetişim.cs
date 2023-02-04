using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TekBaşımaCoreProje1.Models;

namespace TekBaşımaCoreProje1.ViewComponents
{
    public class Ankarailetişim:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var ankarailetişim = yeniİçerik.Ankarailetişim;
            return View(ankarailetişim);
        }
    }
}
