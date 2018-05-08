using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebChat.Data.Model;

namespace WebChat.Data.DataContext
{
    public class WebChatContext : DbContext
    {
        public DbSet<Kullanici> Kullanici { get; set; }

        public DbSet<Mesajlar> Mesajlar { get; set; }
    }
}
