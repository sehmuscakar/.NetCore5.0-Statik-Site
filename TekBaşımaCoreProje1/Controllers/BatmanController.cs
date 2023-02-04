using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TekBaşımaCoreProje1.Models;

namespace TekBaşımaCoreProje1.Controllers
{
    public class BatmanController : Controller
    {
        public IActionResult Index()
        {
            var veribatman = ArvesoftVeriİçerik.batmanveriler;
            return View(veribatman);
        }
        [HttpGet]
        public IActionResult Batmankişioluştur()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Batmankişioluştur(ArvesoftVeriTanımlama arvesoftVeriTanımlama)
        {
            if (ModelState.IsValid)
            {
                ArvesoftVeriTanımlama sonkisi = null;
                if (ArvesoftVeriİçerik.batmanveriler.Count > 0)
                {
                    sonkisi = ArvesoftVeriİçerik.batmanveriler.Last();
                }
                arvesoftVeriTanımlama.ID = 1;
                if (sonkisi != null)
                {
                    arvesoftVeriTanımlama.ID = sonkisi.ID + 1;
                }

                ArvesoftVeriİçerik.batmanveriler.Add(arvesoftVeriTanımlama);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Batmanverikaldır(int id)
        {
            var kaldır = ArvesoftVeriİçerik.batmanveriler.Find(I => I.ID == id);
            ArvesoftVeriİçerik.batmanveriler.Remove(kaldır);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Batmanverigüncelle(int id)// mesela guncelle butonuna bastığımızda veriler geldiğinde bunun sayesinde geliyor
        {
            var guncele = ArvesoftVeriİçerik.batmanveriler.Find(I => I.ID == id);

            return View(guncele);
        }

        [HttpPost]
        public IActionResult Batmanverigüncelle(ArvesoftVeriTanımlama arvesoftVeriTanımlama)
        {
            var updatekişi = ArvesoftVeriİçerik.batmanveriler.Find(I => I.ID == arvesoftVeriTanımlama.ID);
            updatekişi.Adı = arvesoftVeriTanımlama.Adı;
            updatekişi.Soyadı = arvesoftVeriTanımlama.Soyadı;
            updatekişi.Kıdemi = arvesoftVeriTanımlama.Kıdemi;
            updatekişi.Görevi = arvesoftVeriTanımlama.Görevi;
            updatekişi.Yaşı = arvesoftVeriTanımlama.Yaşı;
            return RedirectToAction("Index");
        }
    }
}

