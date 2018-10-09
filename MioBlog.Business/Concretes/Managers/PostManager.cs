using System.Collections.Generic;
using System.Threading;
using MioBlog.Business.Abstracts;
using MioBlog.Business.ValidationRules.FluentValidation;
using MioBlog.DataAccess.Abstracts;
using MioBlog.Entities.Concretes;
using MioBlog.Core.Aspects.Postsharp;
using MioBlog.Core.Aspects.Postsharp.CacheAspects;
using MioBlog.Core.Aspects.Postsharp.LogAspects;
using MioBlog.Core.Aspects.Postsharp.PerformanceAspects;
using MioBlog.Core.CrossCuttingConcerns.Caching.Microsoft;
using MioBlog.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;

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
        [LogAspect(typeof(DatabaseLogger))]
        [LogAspect(typeof(FileLogger))]
        [PerformanceCounterAspect(3)]
        public List<Post> GetAll()
        {
            // for test
            //Thread.Sleep(5000);

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
