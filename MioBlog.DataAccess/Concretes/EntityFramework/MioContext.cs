using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MioBlog.DataAccess.Concretes.EntityFramework.Mappings;
using MioBlog.Entities.Concretes;

namespace MioBlog.DataAccess.Concretes.EntityFramework
{
    public class MioContext : DbContext
    {
        public MioContext() :
            base("data source=.; initial catalog=MioBlogDB; integrated security=true;")
        {
            Database.SetInitializer<MioContext>(null);
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<Log> Logs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PostCategoryMap());
            modelBuilder.Configurations.Add(new PostMap());
            modelBuilder.Configurations.Add(new LogMap());
        }
    }
}
