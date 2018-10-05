using System.Collections.Generic;
using MioBlog.Entities.Concretes;

namespace MioBlog.Business.Abstracts
{
    public interface IPostService
    {
        List<Post> GetAll();
        List<Post> GetAllWithCategoryId(int postCategoryId);
        Post GetById(int postId);
        Post Add(Post post);
        Post Update(Post post);
        void Delete(Post post);
    }
}
