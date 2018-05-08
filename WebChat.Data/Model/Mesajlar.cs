using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebChat.Data.Model
{
    public class Mesajlar
    {
        public int ID { get; set; }

        

        [Required]
        public int ALN { get; set; } 
        public virtual Kullanici kullaniciALN{ get; set; }

        [Required]
        public int GND { get; set; }
        public virtual Kullanici kullaniciGND { get; set; }

        public string Mesaj { get; set; }

        public DateTime Tarih { get; set; }

        public bool Okundu { get; set; }

        public bool Aktif { get; set; }


    }
}
