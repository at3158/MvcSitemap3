using MvcSitemap3.Models.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcSitemap3.Service
{
    internal class SmMenuService<T> : IDisposable
    {
        private SmDbContext _dbContext = new SmDbContext();

        public SmMenuService()
        {
            this._dbContext.Set<SmMenu>().AsNoTracking();
        }

        public virtual void Add(SmMenu entity)
        {
            this._dbContext.SmMenus.Add(entity);
            this._dbContext.SaveChanges();
        }


        public IQueryable<SmMenu> Get(Func<SmMenu, bool> filter)
        {
            return this._dbContext.SmMenus.Where(filter).AsQueryable();
        }
        public virtual IQueryable<SmMenu> GetAll()
        {
            return this._dbContext.SmMenus.AsQueryable();
        }

        public virtual void Remove(SmMenu entity)
        {
            this._dbContext.SmMenus.Remove(entity);
            this._dbContext.SaveChanges();
        }

        public virtual void Update(SmMenu entity)
        {
            this._dbContext.SaveChanges();
        }

        public void Dispose()
        {
        }
    }
}