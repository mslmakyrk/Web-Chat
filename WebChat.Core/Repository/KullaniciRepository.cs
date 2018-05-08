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
    public class KullaniciRepository
    {
        private readonly WebChatContext context = new WebChatContext();

        public void Delete(int id)
        {
            var kullanici = GetById(id);
            if (kullanici != null)
            {
                context.Kullanici.Remove(kullanici);
            }
        }

        public Kullanici Get(Expression<Func<Kullanici, bool>> expression)
        {
            return context.Kullanici.FirstOrDefault(expression);
        }

        public IEnumerable<Kullanici> GetAll()
        {
            return context.Kullanici.Select(x => x);
        }

        public Kullanici GetById(int id)
        {
            return context.Kullanici.FirstOrDefault(x => x.ID == id);
        }
        public Kullanici GetByMail(String mail)
        {
            return context.Kullanici.FirstOrDefault(x => x.Mail == mail);
        }

        public IQueryable<Kullanici> GetMany(Expression<Func<Kullanici, bool>> expression)
        {
            return context.Kullanici.Where(expression);
        }

        public void Insert(Kullanici obj)
        {
            try
            {
                context.Kullanici.Add(obj);
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

        public void Update(Kullanici obj)
        {
            context.Kullanici.AddOrUpdate(obj);
        }


    }
}
