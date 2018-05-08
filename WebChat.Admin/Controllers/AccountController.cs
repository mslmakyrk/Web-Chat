using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebChat.Core.Repository;
using WebChat.Data.Model;

namespace WebChat.Admin.Controllers
{
    public class AccountController : Controller
    {
        private readonly KullaniciRepository _kullaniciRepository = new KullaniciRepository();
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Kullanici kullanici )
        {
            var kontrol = _kullaniciRepository.GetMany(x => x.Mail == kullanici.Mail && x.Sifre == kullanici.Sifre).SingleOrDefault();
            if (kontrol != null)
            {
                if (kontrol.Rol == 1 || kontrol.Rol == 2)
                {
                    Session["KullaniciEmail"] = kullanici.Mail;
                    Session["Rol"] = kontrol.Rol;
                    return RedirectToAction("Chat", "Chat");
                }
                ViewBag.Mesaj = "Yetkiisiz Kullanıcı";
                return View();
            }
            ViewBag.Mesaj = "Kullanıcı Bulunamadı";
            return View();
        }
    }
}