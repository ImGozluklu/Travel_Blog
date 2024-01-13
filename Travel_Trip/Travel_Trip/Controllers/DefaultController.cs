using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip.Models.Siniflar;
namespace Travel_Trip.Controllers
{
    public class DefaultController : Controller
    {
        Context db = new Context();
        public ActionResult Index()
        {
            var degerler = db.Blogs.ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial()
        {
            var degerler = db.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial2()
        {
            var deger = db.Blogs.Take(10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial4()
        {
            var deger = db.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            var deger = db.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(deger);

        }




    }
}