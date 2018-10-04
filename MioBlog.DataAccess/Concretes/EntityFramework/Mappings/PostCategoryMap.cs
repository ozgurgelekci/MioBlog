using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MioBlog.Entities.Concretes;

namespace MioBlog.DataAccess.Concretes.EntityFramework.Mappings
{
    public class PostCategoryMap : EntityTypeConfiguration<PostCategory>
    {
        public PostCategoryMap()
        {
            ToTable(@"PostCategories", @"dbo");
            HasKey(p => p.PostCategoryId);

            Property(p => p.PostCategoryId).HasColumnName("PostCategoryId");
            Property(p => p.PostCategoryName).HasColumnName("PostCategoryName").HasMaxLength(20);
            Property(p => p.InsertedDate).HasColumnName("InsertedDate");
        }
    }
}
