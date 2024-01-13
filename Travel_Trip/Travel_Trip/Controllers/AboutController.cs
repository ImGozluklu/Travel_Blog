using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip.Models.Siniflar;

namespace Travel_Trip.Controllers
{
    public class AboutController : Controller
    {
        Context db = new Context();

        public ActionResult Index()
        {
            var degerler = db.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}