using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MioBlog.Entities.Concretes;

namespace MioBlog.DataAccess.Concretes.EntityFramework.Mappings
{
   public class UserRoleMap:EntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
            ToTable(@"UserRoles", @"dbo");
            HasKey(u => u.UserRoleId);

            Property(u => u.UserRoleId).HasColumnName("UserRoleId");
            Property(u => u.UserId).HasColumnName("UserId");
            Property(u => u.RoleId).HasColumnName("RoleId");
        }   
    }
}
