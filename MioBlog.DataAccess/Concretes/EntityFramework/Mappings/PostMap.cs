using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MioBlog.Entities.Concrete;

namespace MioBlog.DataAccess.Concretes.EntityFramework.Mappings
{
    public class PostMap:EntityTypeConfiguration<Post>
    {
        public PostMap()
        {
            ToTable(@"Posts", @"dbo");
            HasKey(p => p.PostId);

            Property(p => p.PostId).HasColumnName("PostId");
            Property(p => p.PostCategoryId).HasColumnName("PostCategoryId");
            Property(p => p.PostTitle).HasColumnName("PostTitle");
            Property(p => p.PostSummary).HasColumnName("PostSummary");
            Property(p => p.PostContent).HasColumnName("PostContent");
            Property(p => p.CoverPic).HasColumnName("CoverPic");
            Property(p => p.InsertedDate).HasColumnName("InsertedDate");
        }
    }
}
