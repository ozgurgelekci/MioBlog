using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MioBlog.Core.Entities;

namespace MioBlog.Entities.Concretes
{
    public class Post : IEntity
    {
        public virtual int PostId { get; set; }
        public virtual int PostCategoryId { get; set; }
        public virtual string PostTitle { get; set; }
        public virtual string PostSummary { get; set; }
        public virtual string PostContent { get; set; }
        public virtual string CoverPic { get; set; }
        public virtual DateTime InsertedDate { get; set; }

        public PostCategory PostCategory { get; set; }
    }
}
