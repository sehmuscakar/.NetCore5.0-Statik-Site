using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TekBaşımaCoreProje1.Models;

namespace TekBaşımaCoreProje1.Controllers
{
    public class ŞanlıurfaController : Controller
    {
        public IActionResult Index()
        {
            var verişanlıurfa = ArvesoftVeriİçerik.şanlıurfaveriler;
            return View(verişanlıurfa);
        }
        [HttpGet]
        public IActionResult Şanlıurfakişioluştur()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Şanlıurfakişioluştur(ArvesoftVeriTanımlama arvesoftVeriTanımlama)
        {
            if (ModelState.IsValid)
            {
                ArvesoftVeriTanımlama sonkisi = null;
                if (ArvesoftVeriİçerik.şanlıurfaveriler.Count > 0)
                {
                    sonkisi = ArvesoftVeriİçerik.şanlıurfaveriler.Last();
                }
                arvesoftVeriTanımlama.ID = 1;
                if (sonkisi != null)
                {
                    arvesoftVeriTanımlama.ID = sonkisi.ID + 1;
                }

                ArvesoftVeriİçerik.şanlıurfaveriler.Add(arvesoftVeriTanımlama);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Şanlıurfaverikaldır(int id)
        {
            var kaldır = ArvesoftVeriİçerik.şanlıurfaveriler.Find(I => I.ID == id);
            ArvesoftVeriİçerik.şanlıurfaveriler.Remove(kaldır);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ŞanlıUrfaverigüncelle(int id)// mesela guncelle butonuna bastığımızda veriler geldiğinde bunun sayesinde geliyor
        {
            var guncele = ArvesoftVeriİçerik.şanlıurfaveriler.Find(I => I.ID == id);

            return View(guncele);
        }

        [HttpPost]
        public IActionResult ŞanlıUrfaverigüncelle(ArvesoftVeriTanımlama arvesoftVeriTanımlama)
        {
            var updatekişi = ArvesoftVeriİçerik.şanlıurfaveriler.Find(I => I.ID == arvesoftVeriTanımlama.ID);
            updatekişi.Adı = arvesoftVeriTanımlama.Adı;
            updatekişi.Soyadı = arvesoftVeriTanımlama.Soyadı;
            updatekişi.Kıdemi = arvesoftVeriTanımlama.Kıdemi;
            updatekişi.Görevi = arvesoftVeriTanımlama.Görevi;
            updatekişi.Yaşı = arvesoftVeriTanımlama.Yaşı;
            return RedirectToAction("Index");
        }
    }
}

