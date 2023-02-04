using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TekBaşımaCoreProje1.Models;

namespace TekBaşımaCoreProje1.Controllers
{
    public class HomeController : Controller
    {

        //burda sadece verileri getirdik

      

        public IActionResult Index()
        {
            var veritipleritanımlamamodelis = VeriContext_icerik_.veriTipleriTanımlamaModelis;
            return View(veritipleritanımlamamodelis);// tanımladığımız verileri veriTipleriTanımlamaModelis nesnesi sayesinde viewe dündürecez
        }
        [HttpGet]//sadece verileri getirir aslında httpget yazmasanda o gizli bi httpget vardır
        public IActionResult Yenikişioluştur()
        {
            return View();
        }
      [HttpPost]//buda verileri göndermek için kullanılır 
        public IActionResult Yenikişioluştur(VeriTipleriTanımlamaModeli veriTipleriTanımlamaModeli)// biz burdan VeriTipleriTanımlamaModeli sınıfına gitik ve o sınıftan veriTipleriTanımlamaModeli nesnesi oluşturduk 
            //bu nesne ile yeni kişi oluşturacaz 
        {
            if (ModelState.IsValid) { 

            VeriTipleriTanımlamaModeli sonkişi = null;
            if(VeriContext_icerik_.veriTipleriTanımlamaModelis.Count>0)
            {
                sonkişi= VeriContext_icerik_.veriTipleriTanımlamaModelis.Last();
            }
            veriTipleriTanımlamaModeli.ID = 1;
            if (sonkişi != null)
            {
                veriTipleriTanımlamaModeli.ID = sonkişi.ID + 1;//yani son kişi eklemdiğinde id artacak 
            }
            //veri ekleme kısmı bu tek üstekiler id artırma algoritması 
            VeriContext_icerik_.veriTipleriTanımlamaModelis.Add(veriTipleriTanımlamaModeli);

            return RedirectToAction("Index");
        }
            return View();
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            var kişikaldır = VeriContext_icerik_.veriTipleriTanımlamaModelis.Find(I => I.ID == id);
            VeriContext_icerik_.veriTipleriTanımlamaModelis.Remove(kişikaldır);//burda da bulunan id kaldırılır
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id) // burda güncelleye bastığımızda verileri inputların içine getiriyor
        {
            var updateKişi = VeriContext_icerik_.veriTipleriTanımlamaModelis.Find(a => a.ID == id);//burdaki mantık:fare ile tılanınca tıklanan id endpoindeki iddir o id ile veriTanımlamaModelindeki ID birbirine eşit ise getiriyor
            return View(updateKişi);
        }

        [HttpPost]
        public IActionResult Update(VeriTipleriTanımlamaModeli veriTipleriTanımlamaModeli)
        {
            var updatekişi = VeriContext_icerik_.veriTipleriTanımlamaModelis.Find(I => I.ID == veriTipleriTanımlamaModeli.ID);//burda ise bu ID gelen verinin ID si 1 ci ID olan 2Cİ ID de nesne aracılığıyla gelen ID birbirine eşit ise 
            updatekişi.Proje = veriTipleriTanımlamaModeli.Proje;
            updatekişi.Sehir = veriTipleriTanımlamaModeli.Sehir;
            updatekişi.Ücret = veriTipleriTanımlamaModeli.Ücret;
            return RedirectToActionPermanent("Index");

        }
    }
}
