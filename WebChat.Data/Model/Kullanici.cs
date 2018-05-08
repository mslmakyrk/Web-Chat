using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebChat.Data.Model
{
    public class Kullanici
    {
        public int ID { get; set; }

        [Required]
        public string AdSoyad { get; set; }

        public string Sifre { get; set; }

        public string Mail { get; set; }

        public string Telefon { get; set; }

        [Required]
        public int Rol { get; set; }

        public virtual List<Mesajlar> Mesajlar { get; set; }
    }
}
