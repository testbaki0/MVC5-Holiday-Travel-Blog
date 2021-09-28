using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TatilSeyahatMVC.Models.Siniflar;

namespace TatilSeyahatMVC.Controllers
{
    public class GirisController : Controller
    {
        Context c = new Context();
        // GET: Giris
        public ActionResult Login()
        {
            return View();
        }
        // kullanici girişi (authentication)
        [HttpPost]
        public ActionResult Login(Admin p)
        {
            var control = c.Admins.FirstOrDefault(x => x.User == p.User && x.Password == p.Password);
            if (control != null)
            {
                FormsAuthentication.SetAuthCookie(control.User, false);
                Session["User"] = control.User.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
        // log out (çıkış yap)
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Giris");
        }
    }
}