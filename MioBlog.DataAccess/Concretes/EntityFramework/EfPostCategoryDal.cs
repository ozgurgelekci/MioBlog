using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MioBlog.Core.DataAccess.Concretes.EntityFramework;
using MioBlog.DataAccess.Abstracts;
using MioBlog.Entities.Concretes;

namespace MioBlog.DataAccess.Concretes.EntityFramework
{
    public class EfPostCategoryDal : EfEntityRepositoryBase<PostCategory, MioContext>, IPostCategoryDal
    {

    }
}
