using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebChat.Data.DataContext;
using WebChat.Data.Model;

namespace WebChat.Core.Repository
{
    public class MesajRepository
    {
        private readonly WebChatContext context = new WebChatContext();

        public void Delete(int id)
        {
            var mesaj = GetById(id);
            if (mesaj != null)
            {
                context.Mesajlar.Remove(mesaj);
            }
        }

        public Mesajlar Get(Expression<Func<Mesajlar, bool>> expression)
        {
            return context.Mesajlar.FirstOrDefault(expression);
        }

        public IEnumerable<Mesajlar> GetAll()
        {
            return context.Mesajlar.Select(x => x);
        }

        public Mesajlar GetById(int id)
        {
            return context.Mesajlar.FirstOrDefault(x => x.ID == id);
        }
       

        public IQueryable<Mesajlar> GetMany(Expression<Func<Mesajlar, bool>> expression)
        {
            return context.Mesajlar.Where(expression);
        }

        public void Insert(Mesajlar obj)
        {
            try
            {
                context.Mesajlar.Add(obj);
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Mesajlar obj)
        {
            context.Mesajlar.AddOrUpdate(obj);
        }


    }
}

