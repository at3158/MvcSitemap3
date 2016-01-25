using MvcSitemap3.Models.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcSitemap3.Service
{
    public class SmRoleService: IDisposable
    {
        private SmDbContext _dbContext = new SmDbContext();

        public SmRoleService()
        {
            this._dbContext.Set<SmRole>().AsNoTracking();
        }

        public virtual void Add(SmRole entity)
        {
            this._dbContext.SmRoles.Add(entity);
            this._dbContext.SaveChanges();
        }


        public IQueryable<SmRole> Get(Func<SmRole, bool> filter)
        {
            return this._dbContext.SmRoles.Where(filter).AsQueryable();
        }
        public virtual IQueryable<SmRole> GetAll()
        {
            return this._dbContext.SmRoles.AsQueryable();
        }

        public virtual void Remove(SmRole entity)
        {
            this._dbContext.SmRoles.Remove(entity);
            this._dbContext.SaveChanges();
        }

        public virtual void Update(SmRole entity)
        {
            this._dbContext.SaveChanges();
        }

        public void Dispose()
        {
        }
    }
}