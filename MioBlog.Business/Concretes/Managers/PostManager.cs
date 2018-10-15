using System.Collections.Generic;
using System.Threading;
using AutoMapper;
using MioBlog.Business.Abstracts;
using MioBlog.Business.ValidationRules.FluentValidation;
using MioBlog.DataAccess.Abstracts;
using MioBlog.Entities.Concretes;
using MioBlog.Core.Aspects.Postsharp;
using MioBlog.Core.Aspects.Postsharp.AuthorizationAspects;
using MioBlog.Core.Aspects.Postsharp.CacheAspects;
using MioBlog.Core.Aspects.Postsharp.LogAspects;
using MioBlog.Core.Aspects.Postsharp.PerformanceAspects;
using MioBlog.Core.CrossCuttingConcerns.Caching.Microsoft;
using MioBlog.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using MioBlog.Core.Utilities.Mappings;

namespace MioBlog.Business.Concretes.Managers
{
    public class PostManager : IPostService
    {
        private IPostDal _postDal;
        private IMapper _mapper;

        public PostManager(IPostDal postDal, IMapper mapper)
        {
            _postDal = postDal;
            _mapper = mapper;
        }

        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        [LogAspect(typeof(DatabaseLogger))]
        [LogAspect(typeof(FileLogger))]
        [PerformanceCounterAspect(3)]
        [SecuredOperation(Roles = "Student")]
        public List<Post> GetAll()
        {
            // for test
            //Thread.Sleep(5000);

            //return _postDal.GetList();

            var posts = _mapper.Map<List<Post>>(_postDal.GetList());
            return posts;
        }
        
        [CacheAspect(typeof(MemoryCacheManager))]
        [LogAspect(typeof(DatabaseLogger))]
        [SecuredOperation(Roles = "Admin")]
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
