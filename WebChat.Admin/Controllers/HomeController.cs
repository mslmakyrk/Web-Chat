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
    public class HomeController : Controller
    {
        private readonly KullaniciRepository _kullaniciRepository=new KullaniciRepository();
        // GET: Home

        [LoginFilter]
        public ActionResult Index()
        {
            return View();
        }

        #region Ekle
        [LoginFilter]
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [LoginFilter]
        [HttpPost]
        public JsonResult Ekle(Kullanici kullanici)
        {
            try
            {
                Kullanici kln = _kullaniciRepository.GetByMail(kullanici.Mail);
                if (kln == null)
                {
                    _kullaniciRepository.Insert(kullanici);
                    _kullaniciRepository.Save();
                    return Json("Kullanıcı Kaydı Başarıyla Yapıldı");
                }
                return Json("Girdiğiniz E-Mail Sisteme Kayıtlı");
                
            }
            catch (Exception ex)
            {

                return Json(ex.Message);
            }

        }
        #endregion

        #region Listele
        [LoginFilter]
        public ActionResult Listele()
        {
            return View(_kullaniciRepository.GetAll().ToList());
        }

        #endregion

        #region Düzenle
        [LoginFilter]
        [HttpGet]
        public ActionResult Duzenle(int id)
        {
            Kullanici dbKullanici = _kullaniciRepository.GetById(id);
            if (dbKullanici == null)
                throw new Exception("Kullanıcı Bulunamadı");
            return View(dbKullanici);
        }
        [LoginFilter]
        [HttpPost]
        public JsonResult Duzenle(Kullanici kullanici)
        {
            try
            {
                Kullanici dbKullanici = _kullaniciRepository.GetById(kullanici.ID);
                dbKullanici.AdSoyad = kullanici.AdSoyad;
                dbKullanici.Mail = kullanici.Mail;
                dbKullanici.Telefon = kullanici.Telefon;
                dbKullanici.Rol = kullanici.Rol;
                dbKullanici.Sifre = kullanici.Sifre;
                _kullaniciRepository.Save();
                return Json("Güncelleme Başarı ile Yapıldı.");
            }
            catch (Exception ex)
            {
                return Json("Hata : " + ex);
            }
        }

        #endregion

        #region Sil
        [LoginFilter]
        public JsonResult Sil(int ID)
        {
            try
            {
                Kullanici dbKategori = _kullaniciRepository.GetById(ID);
                if (dbKategori == null)
                {
                    return Json("Silinecek Kayıt Bulunamadı.");
                }
                _kullaniciRepository.Delete(ID);
                _kullaniciRepository.Save();
                return Json("Kayıt Başarılı Bir Şekilde Silindi");
            }
            catch (Exception ex)
            {

                return Json("Hata : " + ex);
            }
            
        }
        #endregion


    }
}