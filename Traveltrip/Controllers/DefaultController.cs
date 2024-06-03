using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Traveltrip.Controllers;
using Traveltrip.Models.Sınıflar;
namespace Traveltrip.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()   // metotun ismi index  metotun tipi actionresult(aksiyon sonucu)
        {
           var degerler = c.Blogs.Take(10).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {

            return View();
        }
        public PartialViewResult Partial1()
        { 
            var degerler =c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        
        }
        public PartialViewResult Partial2()
        {
            var deger = c.Blogs.Where(x => x.ID > 8).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.Take(10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            var deger = c.Blogs.Take(2).OrderByDescending(x => x.ID).ToList();
            return PartialView(deger);
        }

    }
}