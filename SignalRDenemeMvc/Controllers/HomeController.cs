using SignalRDenemeMvc.Context;
using SignalRDenemeMvc.Models;
using SignalRDenemeMvc.SignalHub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRDenemeMvc.Controllers
{
    public class HomeController : Controller
    {
        DiyetisyenDBEntities db = new DiyetisyenDBEntities();
        public ActionResult Index()
        {
          
            return View();
        }
        public string PersonelleriGetir()
        {
            VeritabaniIslemleri Veri = new VeritabaniIslemleri();
            var Personeller = Veri.PersonelleriGetir();
            return Helper.RazorViewRender(Personeller, "~/Views/Home/PersonelleriGetir.cshtml");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

       
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}