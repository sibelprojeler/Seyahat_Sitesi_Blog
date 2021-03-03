using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeyahatSitesi.Models.Siniflar;

namespace SeyahatSitesi.Controllers
{
    public class HakkımızdaController : Controller
    {
        Context db = new Context();
        public ActionResult Index()
        {
            var degerler = db.Hakkımızdas.ToList();
            return View(degerler);
        }
    }
}