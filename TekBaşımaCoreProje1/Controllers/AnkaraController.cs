using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TekBaşımaCoreProje1.Models;

namespace TekBaşımaCoreProje1.Controllers
{
    public class AnkaraController : Controller
    {
        public IActionResult Index()
        {
            var veriankara = ArvesoftVeriİçerik.ankaraveriler;
            return View(veriankara);
        }
        [HttpGet]
        public IActionResult Ankarakişioluştur()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ankarakişioluştur(ArvesoftVeriTanımlama arvesoftVeriTanımlama)
        {
            if (ModelState.IsValid)
            {
                ArvesoftVeriTanımlama sonkisi = null;
                if (ArvesoftVeriİçerik.ankaraveriler.Count > 0)
                {
                    sonkisi = ArvesoftVeriİçerik.ankaraveriler.Last();
                }
                arvesoftVeriTanımlama.ID = 1;
                if (sonkisi != null)
                {
                    arvesoftVeriTanımlama.ID = sonkisi.ID + 1;
                }

                ArvesoftVeriİçerik.ankaraveriler.Add(arvesoftVeriTanımlama);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Ankaraverikaldır(int id)
        {
            var kaldır = ArvesoftVeriİçerik.ankaraveriler.Find(I => I.ID == id);
            ArvesoftVeriİçerik.ankaraveriler.Remove(kaldır);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Ankaraverigüncelle(int id)// mesela guncelle butonuna bastığımızda veriler geldiğinde bunun sayesinde geliyor
        {
            var guncele = ArvesoftVeriİçerik.ankaraveriler.Find(I => I.ID == id);

            return View(guncele);
        }

        [HttpPost]
        public IActionResult Ankaraverigüncelle(ArvesoftVeriTanımlama arvesoftVeriTanımlama)
        {
            var updatekişi = ArvesoftVeriİçerik.ankaraveriler.Find(I => I.ID == arvesoftVeriTanımlama.ID);
            updatekişi.Adı = arvesoftVeriTanımlama.Adı;
            updatekişi.Soyadı = arvesoftVeriTanımlama.Soyadı;
            updatekişi.Kıdemi = arvesoftVeriTanımlama.Kıdemi;
            updatekişi.Görevi = arvesoftVeriTanımlama.Görevi;
            updatekişi.Yaşı = arvesoftVeriTanımlama.Yaşı;
            return RedirectToAction("Index");
        }
    }
}

