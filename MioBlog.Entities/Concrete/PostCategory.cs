using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MioBlog.Core.Entities;

namespace MioBlog.Entities.Concrete
{
    public class PostCategory : IEntity
    {
        public int PostCategoryId { get; set; }
        public string PostCategoryName { get; set; }
        public DateTime InsertedDate { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
