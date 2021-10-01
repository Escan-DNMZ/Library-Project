using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kitaplık.Models;

namespace Kitaplık.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            var ktp = new List<Kitaplar>(){
                new Kitaplar() {Id=1,KitapAd="yapay zeka 101",Yazar="Unknown"},
                new Kitaplar() {Id=2,KitapAd="Web tasarım",Yazar="Unknown"},
                new Kitaplar() {Id=3,KitapAd= "Web geliştirme",Yazar="Unknown"}
            };
            

            return View(ktp);
        }
        public IActionResult Home(){
            int saat = DateTime.Now.Hour;
            string mesaj = saat > 12? "iyi günler":"Günaydın";
            ViewBag.clock = mesaj;
            return View();
        }

         public IActionResult Pricing(){
             var prc = new List<Pricing>(){
                 new Pricing() {Id=1,KitapAd="yapay zeka 101",Price=20},
                 new Pricing() {Id=2,KitapAd="Web tasarım",Price=40},
                 new Pricing() {Id=3,KitapAd="Web geliştirme",Price=120}

             };

            return View(prc);
        }
    }
}