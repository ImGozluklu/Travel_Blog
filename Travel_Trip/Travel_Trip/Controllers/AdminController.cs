using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip.Models.Siniflar;

namespace Travel_Trip.Controllers
{
    public class AdminController : Controller
    {
        Context db = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = db.Blogs.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            db.Blogs.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");


        }
        public ActionResult BlogSil(int id)
        {
            var deger = db.Blogs.Find(id);
               db.Blogs.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var deger = db.Blogs.Find(id);
            return View("BlogGetir",deger);
        }
        public ActionResult BlogGuncelle(Blog p)
        {
            var deger = db.Blogs.Find(p.ID);
            deger.Baslik = p.Baslik;
            deger.Aciklama = p.Baslik;
            deger.BlogImage = p.BlogImage;
            deger.Tarih = p.Tarih;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
         
        public ActionResult YorumListele()
        {
            var yorumlar = db.Yorumlars.ToList();
            return View(yorumlar);
        }

        public ActionResult YorumSil(int id)
        {
            var deger = db.Yorumlars.Find(id);
            db.Yorumlars.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("YorumListele");
        }
        public ActionResult YorumGetir(int id)
        {
            var deger = db.Yorumlars.Find(id);
            return View("YorumGetir", deger);
        }
        public ActionResult YorumGuncelle(Yorumlar p)
        {
            var deger = db.Yorumlars.Find(p.ID);
            deger.KullaniciAdi = p.KullaniciAdi;
            deger.Mail = p.Mail;
            deger.Yorum = p.Yorum;
            db.SaveChanges();
            return RedirectToAction("YorumListele");
        }
      
        public ActionResult HakkizdaGetir()
        {
            var deger = db.Hakkimizdas.Find(1);
            return View("HakkizdaGetir", deger);
        }
        public ActionResult HakkizdaGuncelle(Hakkimizda p)
        {
            var deger = db.Hakkimizdas.Find(1);
            deger.Aciklama = p.Aciklama;
            deger.PhotoUrl = p.PhotoUrl;
            
            db.SaveChanges();
            return RedirectToAction("HakkizdaGetir");
        }

    }
}