using MvcSitemap3.Models.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcSitemap3.Service
{
    public class SmUserRoleService:IDisposable
    {
        private SmDbContext _dbContext = new SmDbContext();

        public SmUserRoleService()
        {
            this._dbContext.Set<SmUserRole>().AsNoTracking();
        }

        public virtual void Add(SmUserRole entity)
        {
            this._dbContext.SmUserRoles.Add(entity);
            this._dbContext.SaveChanges();
        }


        public IQueryable<SmUserRole> Get(Func<SmUserRole, bool> filter)
        {
            return this._dbContext.SmUserRoles.Where(filter).AsQueryable();
        }
        public virtual IQueryable<SmUserRole> GetAll()
        {
            return this._dbContext.SmUserRoles.AsQueryable();
        }

        public virtual void Remove(SmUserRole entity)
        {
            this._dbContext.SmUserRoles.Remove(entity);
            this._dbContext.SaveChanges();
        }

        public virtual void Update(SmUserRole entity)
        {
            this._dbContext.SaveChanges();
        }

        public void Dispose()
        {
        }
    }
}