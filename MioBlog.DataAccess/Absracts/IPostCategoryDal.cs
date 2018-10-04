using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MioBlog.Core.DataAccess.Abstracts;
using MioBlog.Entities.Concrete;

namespace MioBlog.DataAccess.Absracts
{
    public interface IPostCategoryDal : IEntityRepository<PostCategory>
    {

    }
}
