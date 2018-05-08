using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebChat.Admin.CustomFilter;
using WebChat.Admin.Hubs;
using WebChat.Core.Repository;
using WebChat.Data.Model;

namespace WebChat.Admin.Controllers
{
    public class ChatController : Controller
    {
        private readonly KullaniciRepository _kullanici = new KullaniciRepository();
        #region Giriş
        // GET: Chat
        [LoginFilter]
        public ActionResult Giris()
        {
            return View();
        }
        #endregion

        #region Chat
        [LoginFilter]
        public ActionResult Chat()
        {
            string ad = Session["KullaniciEmail"].ToString();
            Kullanici k = _kullanici.GetByMail(ad);

            int rol = Convert.ToInt32(Session["Rol"]);
            WebChatHub hub = new WebChatHub();
            //hub.Connect(mail);
            ViewBag.ad = ad;
            ViewBag.rol = rol;
            ViewBag.id = k.ID;
            return View();
        }
        #endregion

    }
}