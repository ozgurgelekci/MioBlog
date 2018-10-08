using System.Collections.Generic;
using MioBlog.Business.Abstracts;
using MioBlog.Business.ValidationRules.FluentValidation;
using MioBlog.DataAccess.Abstracts;
using MioBlog.Entities.Concretes;
using MioBlog.Core.Aspects.Postsharp;
using MioBlog.Core.Aspects.Postsharp.CacheAspects;
using MioBlog.Core.CrossCuttingConcerns.Caching.Microsoft;

namespace MioBlog.Business.Concretes.Managers
{
    public class PostManager : IPostService
    {
        private IPostDal _postDal;

        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Post> GetAll()
        {
            return _postDal.GetList();
        }

        public List<Post> GetAllWithCategoryId(int postCategoryId)
        {
            return _postDal.GetList(p => p.PostCategoryId == postCategoryId);
        }

        public Post GetById(int postId)
        {
            return _postDal.Get(p => p.PostId == postId);
        }

        [FluentValidationAspect(typeof(PostValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Post Add(Post post)
        {
            return _postDal.Add(post);
        }

        [FluentValidationAspect(typeof(PostValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Post Update(Post post)
        {
            return _postDal.Update(post);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(Post post)
        {
            _postDal.Delete(post);
        }
    }
}
