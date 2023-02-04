using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TekBaşımaCoreProje1.Models;

namespace TekBaşımaCoreProje1.Controllers
{
    public class KonyaController : Controller
    {
        public IActionResult Index()
        {
            var verikonya = ArvesoftVeriİçerik.konyaveriler;
            return View(verikonya);
        }
        [HttpGet]
        public IActionResult Konyakişioluştur()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Konyakişioluştur(ArvesoftVeriTanımlama arvesoftVeriTanımlama)
        {
            if (ModelState.IsValid)
            {
                ArvesoftVeriTanımlama sonkisi = null;
                if (ArvesoftVeriİçerik.konyaveriler.Count > 0)
                {
                    sonkisi = ArvesoftVeriİçerik.konyaveriler.Last();
                }
                arvesoftVeriTanımlama.ID = 1;
                if (sonkisi != null)
                {
                    arvesoftVeriTanımlama.ID = sonkisi.ID + 1;
                }

                ArvesoftVeriİçerik.konyaveriler.Add(arvesoftVeriTanımlama);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Konyaverikaldır(int id)
        {
            var kaldır = ArvesoftVeriİçerik.konyaveriler.Find(I => I.ID == id);
            ArvesoftVeriİçerik.konyaveriler.Remove(kaldır);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Konyaverigüncelle(int id)// mesela guncelle butonuna bastığımızda veriler geldiğinde bunun sayesinde geliyor
        {
            var guncele = ArvesoftVeriİçerik.konyaveriler.Find(I => I.ID == id);

            return View(guncele);
        }

        [HttpPost]
        public IActionResult Konyaverigüncelle(ArvesoftVeriTanımlama arvesoftVeriTanımlama)
        {
            var updatekişi = ArvesoftVeriİçerik.konyaveriler.Find(I => I.ID == arvesoftVeriTanımlama.ID);
            updatekişi.Adı = arvesoftVeriTanımlama.Adı;
            updatekişi.Soyadı = arvesoftVeriTanımlama.Soyadı;
            updatekişi.Kıdemi = arvesoftVeriTanımlama.Kıdemi;
            updatekişi.Görevi = arvesoftVeriTanımlama.Görevi;
            updatekişi.Yaşı = arvesoftVeriTanımlama.Yaşı;
            return RedirectToAction("Index");
        }
    }
}

