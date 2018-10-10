using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MioBlog.Core.DataAccess.Concretes.EntityFramework;
using MioBlog.DataAccess.Abstracts;
using MioBlog.Entities.ComplexTypes;
using MioBlog.Entities.Concretes;

namespace MioBlog.DataAccess.Concretes.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, MioContext>, IUserDal
    {
        public List<UserRoleItem> GetUserRoles(User user)
        {
            using (var context = new MioContext())
            {
                var result = from ur in context.UserRoles
                             join r in context.Roles
                                 on ur.UserId equals user.UserId
                             where ur.UserId == user.UserId
                             select new UserRoleItem { RoleName = r.Name };

                return result.ToList();

            }
        }
    }
}
