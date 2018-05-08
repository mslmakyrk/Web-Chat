using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebChat.Data.Model
{
    public class ViewModel
    {
        public IEnumerable<Kullanici> Kullanici { get; set; }

        public IEnumerable<Mesajlar> Mesaj { get; set; }
    }
}
