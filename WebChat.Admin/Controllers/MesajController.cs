using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebChat.Admin.CustomFilter;
using WebChat.Core.Repository;
using WebChat.Data.Model;

namespace WebChat.Admin.Controllers
{
    public class MesajController : Controller
    {
        private readonly MesajRepository msgRepo = new MesajRepository();
        private readonly KullaniciRepository klnRepo = new KullaniciRepository();
        // GET: Mesaj
        [LoginFilter]
        public ActionResult Listele()
        {
            ViewModel vm = new ViewModel();
            vm.Mesaj=msgRepo.GetAll().ToList();
            vm.Kullanici = klnRepo.GetAll().ToList();
            return View(vm);
        }
      
    }
}