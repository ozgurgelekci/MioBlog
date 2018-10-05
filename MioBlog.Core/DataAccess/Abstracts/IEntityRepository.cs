using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MioBlog.Core.Entities;

namespace MioBlog.Core.DataAccess.Abstracts
{
    public interface IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null);
        TEntity Get(Expression<Func<TEntity, bool>> filter = null);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
