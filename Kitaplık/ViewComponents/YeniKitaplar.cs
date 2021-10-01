using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kitaplık.Models;

namespace Kitaplık.ViewComponents
{
    public class YeniKitaplar: ViewComponent
    {
        public IViewComponentResult Invoke(){
            var kitaplistesi = new List<Kitaplar>{
                new Kitaplar{
                    Id=4,
                    KitapAd="Korku",
                    Yazar="Zweig"
                },
                new Kitaplar{
                    Id=5,
                    KitapAd="Anna Karanina",
                    Yazar="Tolstoy"
                }
            };
            return View(kitaplistesi);
        }
    }
}