using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebChat.Core.Repository;
using WebChat.Data.Model;

namespace WebChat.Admin.Common
{
    public class KayitMSG
    {
        private readonly MesajRepository msgRepo = new MesajRepository();
        private readonly KullaniciRepository klnRepo = new KullaniciRepository();
        public void Kaydet(string Gnd,string Aln,string _mesaj)
        {
            try
            {
                Mesajlar msg = new Mesajlar();
                msg.ALN = Convert.ToInt32(Aln);
                msg.GND= Convert.ToInt32(Gnd);
                msg.Mesaj = _mesaj;
                //  msg.Gnd_ID = Convert.ToInt32(Gnd);
                // msg.Aln_ID = Convert.ToInt32(Aln);
                msg.Tarih = DateTime.Now;
                msg.Okundu = true;
                msg.Aktif = true;
                msgRepo.Insert(msg);
                msgRepo.Save();
            }
            catch (Exception ex)
            {

                Console.Write("hata : " + ex);
            }
            


        }

        public void Kaydet(string Gnd, string _mesaj)
        {
            try
            {
                Mesajlar msg = new Mesajlar();
                msg.ALN = 5;
                msg.GND = Convert.ToInt32(Gnd);
                msg.Mesaj = _mesaj;
                //  msg.Gnd_ID = Convert.ToInt32(Gnd);
                // msg.Aln_ID = Convert.ToInt32(Aln);
                msg.Tarih = DateTime.Now;
                msg.Okundu = true;
                msg.Aktif = true;
                msgRepo.Insert(msg);
                msgRepo.Save();
            }
            catch (Exception ex)
            {

                Console.Write("hata : " + ex);
            }



        }
    }
}