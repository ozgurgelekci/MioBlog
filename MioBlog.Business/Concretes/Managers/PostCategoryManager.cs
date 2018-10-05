using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MioBlog.Business.Abstracts;
using MioBlog.DataAccess.Abstracts;
using MioBlog.Entities.Concretes;

namespace MioBlog.Business.Concretes.Managers
{
    public class PostCategoryManager : IPostCategoryService
    {
        private IPostCategoryDal _postCategoryDal;

        public PostCategoryManager(IPostCategoryDal postCategoryDal)
        {
            _postCategoryDal = postCategoryDal;
        }

        public List<PostCategory> GetAll()
        {
            return _postCategoryDal.GetList();
        }

        public PostCategory GetById(int postCategoryId)
        {
            return _postCategoryDal.Get(p => p.PostCategoryId == postCategoryId);
        }

        public PostCategory Add(PostCategory postCategory)
        {
            return _postCategoryDal.Add(postCategory);
        }

        public PostCategory Update(PostCategory postCategory)
        {
            return _postCategoryDal.Update(postCategory);
        }

        public void Delete(PostCategory postCategory)
        {
            _postCategoryDal.Delete(postCategory);
        }
    }
}
