using MioBlog.Core.DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MioBlog.Entities.Concretes;

namespace MioBlog.DataAccess.Absracts
{
    public interface IPostDal : IEntityRepository<Post>
    {

    }
}
