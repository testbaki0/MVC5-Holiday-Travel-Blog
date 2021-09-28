using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatMVC.Models.Siniflar;
namespace TatilSeyahatMVC.Controllers
{
    public class ContactController : Controller
    {
        Context c = new Context();
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        // iletişim adresi partial
        public PartialViewResult Adresim()
        {
            var conlist = c.Adress.ToList();
            return PartialView(conlist);
        }
        [HttpGet]
      public PartialViewResult MesajGonder()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult MesajGonder(Contact p)
        {
            c.Contacts.Add(p);
            c.SaveChanges();
            return PartialView();
        }
    }
}