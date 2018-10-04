using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MioBlog.Core.Entities;

namespace MioBlog.Core.DataAccess.Abstracts
{
    public interface IQueryableRepository<TEntity> where TEntity : class, IEntity, new()
    {
        IQueryable<TEntity> Table { get; set; }
    }
}
