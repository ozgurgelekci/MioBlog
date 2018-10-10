using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MioBlog.Entities.Concretes;

namespace MioBlog.DataAccess.Concretes.EntityFramework.Mappings
{
   public class RoleMap:EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            ToTable(@"Roles", @"dbo");
            HasKey(r => r.RoleId);

            Property(r => r.RoleId).HasColumnName("RoleId");
            Property(r => r.Name).HasColumnName("Name");
        }
    }
}
