using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeyahatSitesi.Models.Entity;
using SeyahatSitesi.Models.Siniflar;

namespace SeyahatSitesi.Controllers
{
    public class BlogController : Controller
    {
        Context db = new Context();
        BlogYorum by = new BlogYorum();

        public ActionResult Index()
        {
            // var degerler = db.Blogs.ToList();
            by.Deger1 = db.Blogs.ToList();
            by.Deger3 = db.Blogs.OrderByDescending(x =>x.ID).Take(2).ToList();
            by.Deger4 = db.Yorumlars.Take(3).ToList();
            return View(by);
        }

     
        public ActionResult BlogDetay(int id)
        {
            //var degerler = db.Blogs.Where(x => x.ID == id).ToList();

            by.Deger1 = db.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = db.Yorumlars.Where(x => x.Blogid == id).ToList();
            by.Deger5 = db.Yorumlars.Where(x => x.Blogid == id).Take(2).ToList();
            return View(by);

        }
    }
}