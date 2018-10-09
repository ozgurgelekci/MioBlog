using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MioBlog.Entities.Concretes;

namespace MioBlog.DataAccess.Concretes.EntityFramework.Mappings
{
    public class LogMap : EntityTypeConfiguration<Log>
    {
        public LogMap()
        {
            ToTable(@"Logs", @"dbo");
            HasKey(l => l.Id);

            Property(l => l.Id).HasColumnName("Id");
            Property(l => l.Detail).HasColumnName("Detail");
            Property(l => l.Date).HasColumnName("Date");
            Property(l => l.Audit).HasColumnName("Audit").HasMaxLength(50);
        }
    }
}
