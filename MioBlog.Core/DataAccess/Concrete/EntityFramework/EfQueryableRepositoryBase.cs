using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MioBlog.Core.DataAccess.Abstracts;
using MioBlog.Core.Entities;

namespace MioBlog.Core.DataAccess.Concrete.EntityFramework
{

    public class EfQueryableRepositoryBase<TEntity> : IQueryableRepository<TEntity> where TEntity : class, IEntity, new()
    {

        private DbContext _context;
        private IDbSet<TEntity> _entities;

        public EfQueryableRepositoryBase(DbContext context)
        {
            _context = context;
        }


        public IQueryable<TEntity> Table { get; set; }

        protected virtual IDbSet<TEntity> Entities => _entities ?? (_entities = _context.Set<TEntity>());

        //or

        //protected virtual IDbSet<TEntity> Entities
        //{
        //    get { return _entities ?? (_entities = _context.Set<TEntity>()); }
        //}
    }
}
