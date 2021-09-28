using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatMVC.Models.Siniflar;

namespace TatilSeyahatMVC.Controllers
{
    public class AdminContactController : Controller
    {
        Context c = new Context();
        // GET: AdminContact
        [Authorize]
        public ActionResult Index()
        {
          var listele=  c.Contacts.ToList();
            return View(listele);
        }
    }
}