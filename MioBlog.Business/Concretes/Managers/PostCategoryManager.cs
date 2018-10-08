using System.Collections.Generic;
using MioBlog.Business.Abstracts;
using MioBlog.Business.ValidationRules.FluentValidation;
using MioBlog.Core.Aspects.Postsharp;
using MioBlog.Core.Aspects.Postsharp.CacheAspects;
using MioBlog.Core.CrossCuttingConcerns.Caching.Microsoft;
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

        [FluentValidationAspect(typeof(PostCategoryValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public PostCategory Add(PostCategory postCategory)
        {
            return _postCategoryDal.Add(postCategory);
        }

        [FluentValidationAspect(typeof(PostCategoryValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public PostCategory Update(PostCategory postCategory)
        {
            return _postCategoryDal.Update(postCategory);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(PostCategory postCategory)
        {
            _postCategoryDal.Delete(postCategory);
        }
    }
}
