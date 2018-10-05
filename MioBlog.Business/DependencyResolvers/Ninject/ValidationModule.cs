using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MioBlog.Business.ValidationRules.FluentValidation;
using MioBlog.Entities.Concretes;
using Ninject.Modules;

namespace MioBlog.Business.DependencyResolvers.Ninject
{
  public  class ValidationModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Post>>().To<PostValidator>().InSingletonScope();
            Bind<IValidator<PostCategory>>().To<PostCategoryValidator>().InSingletonScope();
        }
    }
}
