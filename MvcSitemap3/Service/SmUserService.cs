using MvcSitemap3.Models.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcSitemap3.Service
{
    public class SmUserService : IDisposable
    {
        private SmDbContext _dbContext = new SmDbContext();

        public SmUserService()
        {
            this._dbContext.Set<SmUser>().AsNoTracking();
        }

        public virtual void Add(SmUser entity)
        {
            this._dbContext.SmUsers.Add(entity);
            this._dbContext.SaveChanges();
        }


        public IQueryable<SmUser> Get(Func<SmUser, bool> filter)
        {
            return this._dbContext.SmUsers.Where(filter).AsQueryable();
        }
        public virtual IQueryable<SmUser> GetAll()
        {
            return this._dbContext.SmUsers.AsQueryable();
        }

        public virtual void Remove(SmUser entity)
        {
            this._dbContext.SmUsers.Remove(entity);
            this._dbContext.SaveChanges();
        }

        public virtual void Update(SmUser entity)
        {
            this._dbContext.SaveChanges();
        }

        public void Dispose()
        {
        }
    }
}