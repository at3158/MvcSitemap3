using MvcSitemap3.Models.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcSitemap3.Service
{
    public class SmRoleMenuService : IDisposable
    {
        private SmDbContext _dbContext = new SmDbContext();

        public SmRoleMenuService()
        {
            this._dbContext.Set<SmRoleMenu>().AsNoTracking();
        }

        public virtual void Add(SmRoleMenu entity)
        {
            this._dbContext.SmRoleMenus.Add(entity);
            this._dbContext.SaveChanges();
        }


        public IQueryable<SmRoleMenu> Get(Func<SmRoleMenu, bool> filter)
        {
            return this._dbContext.SmRoleMenus.Where(filter).AsQueryable();
        }
        public virtual IQueryable<SmRoleMenu> GetAll()
        {
            return this._dbContext.SmRoleMenus.AsQueryable();
        }

        public virtual void Remove(SmRoleMenu entity)
        {
            this._dbContext.SmRoleMenus.Remove(entity);
            this._dbContext.SaveChanges();
        }

        public virtual void Update(SmRoleMenu entity)
        {
            this._dbContext.SaveChanges();
        }

        public void Dispose()
        {
        }
    }
}