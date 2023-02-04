using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TekBaşımaCoreProje1.Models;

namespace TekBaşımaCoreProje1.ViewComponents
{
    public class Batmaniletişim:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var batmaniletişim = yeniİçerik.Batmaniletişim;
            return View(batmaniletişim);

        }
    }
}
