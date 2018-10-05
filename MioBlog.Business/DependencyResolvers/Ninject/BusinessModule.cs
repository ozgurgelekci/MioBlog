using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MioBlog.Business.Abstracts;
using MioBlog.Business.Concretes.Managers;
using MioBlog.Core.DataAccess.Abstracts;
using MioBlog.Core.DataAccess.Concretes.EntityFramework;
using MioBlog.DataAccess.Abstracts;
using MioBlog.DataAccess.Concretes.EntityFramework;
using Ninject.Modules;

namespace MioBlog.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPostService>().To<PostManager>().InSingletonScope();
            Bind<IPostDal>().To<EfPostDal>();

            Bind<IPostCategoryService>().To<PostCategoryManager>().InSingletonScope();
            Bind<IPostCategoryDal>().To<EfPostCategoryDal>();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepositoryBase<>));
            Bind<DbContext>().To<MioContext>();

        }
    }
}
