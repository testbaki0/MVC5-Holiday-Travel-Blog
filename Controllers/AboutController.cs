using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatMVC.Models.Siniflar;

namespace TatilSeyahatMVC.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context c = new Context();
        public ActionResult Index()
        {
            var d = c.Abouts.ToList();
            return View(d);
        }
    }
}