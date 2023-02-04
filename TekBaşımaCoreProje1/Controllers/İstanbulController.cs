using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TekBaşımaCoreProje1.Models;

namespace TekBaşımaCoreProje1.Controllers
{
    public class İstanbulController : Controller
    {
        public IActionResult Index()
        {
            var veriistanbul = ArvesoftVeriİçerik.istanbulveriler;
            return View(veriistanbul);
        }
       [HttpGet]
        public IActionResult İstanbulkişioluştur()
        {
            return View();
        }
        [HttpPost]
        public IActionResult İstanbulkişioluştur(ArvesoftVeriTanımlama arvesoftVeriTanımlama )
        {
            if (ModelState.IsValid) { 
            ArvesoftVeriTanımlama sonkisi = null;
            if (ArvesoftVeriİçerik.istanbulveriler.Count > 0)
            {
                sonkisi = ArvesoftVeriİçerik.istanbulveriler.Last();
            }
            arvesoftVeriTanımlama.ID = 1;
            if (sonkisi != null)
            {
                arvesoftVeriTanımlama.ID = sonkisi.ID + 1;
            }

            ArvesoftVeriİçerik.istanbulveriler.Add(arvesoftVeriTanımlama);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult İstanbulverikaldır(int id)
        {
            var kaldır = ArvesoftVeriİçerik.istanbulveriler.Find(I => I.ID == id);
            ArvesoftVeriİçerik.istanbulveriler.Remove(kaldır);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult İstanbulverigüncelle(int id)// mesela guncelle butonuna bastığımızda veriler geldiğinde bunun sayesinde geliyor
        {
            var guncele = ArvesoftVeriİçerik.istanbulveriler.Find(I => I.ID == id);
         
            return View(guncele);
        }

        [HttpPost]
        public IActionResult İstanbulverigüncelle(ArvesoftVeriTanımlama arvesoftVeriTanımlama)
        {
            var updatekişi = ArvesoftVeriİçerik.istanbulveriler.Find(I => I.ID == arvesoftVeriTanımlama.ID);
            updatekişi.Adı = arvesoftVeriTanımlama.Adı;
            updatekişi.Soyadı = arvesoftVeriTanımlama.Soyadı;
            updatekişi.Kıdemi = arvesoftVeriTanımlama.Kıdemi;
            updatekişi.Görevi = arvesoftVeriTanımlama.Görevi;
            updatekişi.Yaşı = arvesoftVeriTanımlama.Yaşı;
            return RedirectToAction("Index");
        }
    }
}
