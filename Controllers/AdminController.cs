using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatMVC.Models.Siniflar;

namespace TatilSeyahatMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        //blogları admin paneline listele
        Context c = new Context();
        [Authorize]
        public ActionResult Index(int sayfa=1)
        {
            var liste = c.Blogs.OrderByDescending(x => x.ID).ToList();
            return View(liste);
        }
    }
}