using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeyahatSitesi.Models.Siniflar;

namespace SeyahatSitesi.Controllers
{
   

    public class AdminController : Controller
    {
        Context db = new Context();
        // GET: Admin
        public ActionResult Index()
        {
            var degerler = db.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        { return View(); }

        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            db.Blogs.Add(p);
            db.SaveChanges();
            return Redirect("Index");

        }

        public ActionResult BlogSil(int id)
        {
           var degerler= db.Blogs.Find(id);
            db.Blogs.Remove(degerler);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult BlogGetir(int id)
        {
            var degerler = db.Blogs.Find(id);
            return View("BlogGetir", degerler);


        }

        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = db.Blogs.Find(b.ID);
            blg.Baslik = b.Baslik;
            blg.Aciklama = b.Aciklama;
            blg.Tarih = b.Tarih;
            blg.Blogimage = b.Blogimage;
            db.SaveChanges();
            return RedirectToAction("index");
            
        }

        public ActionResult YorumAdmin()
        {
            var degerler = db.Yorumlars.ToList();
            return View(degerler);
        }

        public ActionResult YorumSil(int id)
        {
            var degerler = db.Yorumlars.Find(id);
            db.Yorumlars.Remove(degerler);
            db.SaveChanges();
            return RedirectToAction("YorumAdmin");
        }
        public ActionResult YorumGetir(int id)
        {
            var degerler = db.Yorumlars.Find(id);
            return View("YorumGetir",degerler);


        }

        public ActionResult YorumGuncelle(Yorumlar y)
        { var degerler = db.Yorumlars.Find(y.ID);
            degerler.KullaniciAdi = y.KullaniciAdi;
            degerler.Mail = y.Mail;
            degerler.Yorum = y.Yorum;
            db.SaveChanges();
            return RedirectToAction("YorumAdmin");

        }

       
    }

}