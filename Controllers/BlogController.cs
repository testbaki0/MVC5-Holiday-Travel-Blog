using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatMVC.Models.Siniflar;

namespace TatilSeyahatMVC.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog

        BlogComment bc = new BlogComment();
        Context c = new Context();
        // blogları listele
        public ActionResult Index()
        {
            bc.Deger1 = c.Blogs.ToList();
            bc.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(bc);
        }
     
        public  ActionResult BlogDetail(int id)
        {
            bc.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            bc.Deger2 = c.Comments.Where(x => x.Blogid == id).ToList();
            return View("BlogDetail",bc);

        }
        // yorum yap
        [HttpGet]
        public PartialViewResult CommentAdd(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
    public PartialViewResult CommentAdd(Comment cm)
        {
            c.Comments.Add(cm);
            c.SaveChanges();
            return PartialView();


        }
    }
}