using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatMVC.Models.Siniflar;
namespace TatilSeyahatMVC.Controllers
{
    public class AdminBlogController : Controller
    {
        // GET: AdminBlog
        Context c = new Context();
        // Yeni Blog Ekle
        [Authorize]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
      
        public ActionResult Index(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index","Admin");
        }
        [Authorize]
        // Blog Sil
        public ActionResult BlogDelete(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }

        // ilgili bloğun verilerini taşı
        public ActionResult BlogGetir(int id)
        {
            var getir = c.Blogs.Find(id);
            return View("BlogGetir", getir);
        }

        // blogları güncelle
        public ActionResult BlogGuncelle(Blog bl)
        {
            var upd = c.Blogs.Find(bl.ID);
            upd.Header = bl.Header;
            upd.Explanation = bl.Explanation;
            upd.Date = bl.Date;
            upd.BlogImage = bl.BlogImage;
            c.SaveChanges();
            return RedirectToAction("Index", "AdminBlog");
        }
        [Authorize]

        // bloglardaki yorumları listele
        public ActionResult CommentList()
        {
            var listele = c.Comments.ToList();
            return View(listele);
        }
        [Authorize]
        // yorum sil
        public ActionResult CommentDel(int id)
        {
            var b = c.Comments.Find(id);
            c.Comments.Remove(b);
            c.SaveChanges();
            return View("Index");
        }
        [Authorize]
        //yorum getir
        public ActionResult YorumGetir(int id)
        {
            var getir = c.Comments.Find(id);
            return View("YorumGetir", getir);
        }
        [Authorize]
        // yorum güncelle
        public ActionResult YorumGuncelle(Comment bl)
        {
            var yrm = c.Comments.Find(bl.ID);
            yrm.Coment = bl.Coment;

            c.SaveChanges();
            return RedirectToAction("CommentList");
        }
    }
}