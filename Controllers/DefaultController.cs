using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatMVC.Models.Siniflar;

namespace TatilSeyahatMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        // Anasayfa
        Context c = new Context();
        
        public ActionResult Index()
        {
            var sldr = c.Blogs.Take(3).ToList();
            return View(sldr);
        }
        // son 3 blogu partialdan alma
        public PartialViewResult HomeBlog()
        {
            var homebl = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(homebl);
        }
        // top 10 blog partial 
        public PartialViewResult TopBlog()
        {
            var topbl = c.Blogs.OrderByDescending(x => x.ID).Take(10).ToList();
            return PartialView(topbl);
        }
        // sol partial
       public PartialViewResult OurBest()
        {
            var ourbst = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(ourbst);
        }
        // sağ partial 
        public PartialViewResult OurbestTwo()
        {
            var or = c.Blogs.OrderByDescending(x => x.Header).Take(3).ToList();
            return PartialView(or);
        }

    }
}