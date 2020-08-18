using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VolantUygulama.Models;
using VolantUygulama.ViewModels;

namespace VolantUygulama.Controllers
{
    public class HomeController : Controller
    {
        AlisverisListeViewModel model = new AlisverisListeViewModel();
        
        [HttpGet]
        public ActionResult Index()
        {
            ListeDondur liste = new ListeDondur();
            
            model.urunListe = liste.dondur().ToList();
            return View(model);
        }
        

        [HttpPost]
        public ActionResult Index(string adi,string aciklamasi)
        {
            Urun urun = new Urun(adi,aciklamasi);
            ListeDondur liste = new ListeDondur();
            model.urunListe = liste.dondur().ToList();
            model.urunListe.Add(urun);
            return View(model);
        }
    }
}