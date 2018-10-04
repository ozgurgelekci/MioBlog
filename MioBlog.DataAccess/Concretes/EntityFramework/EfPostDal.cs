using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MioBlog.Core.DataAccess.Concretes.EntityFramework;
using MioBlog.DataAccess.Absracts;
using MioBlog.Entities.Concretes;

namespace MioBlog.DataAccess.Concretes.EntityFramework
{
    public class EfPostDal : EfEntityRepositoryBase<Post, MioContext>, IPostDal
    {
        //other posts methods
    }
}
