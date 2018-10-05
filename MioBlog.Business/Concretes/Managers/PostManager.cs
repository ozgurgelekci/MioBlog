﻿using System.Collections.Generic;
using MioBlog.Business.Abstracts;
using MioBlog.Business.ValidationRules.FluentValidation;
using MioBlog.DataAccess.Abstracts;
using MioBlog.Entities.Concretes;
using MioBlog.Core.Aspects.Postsharp;

namespace MioBlog.Business.Concretes.Managers
{
    public class PostManager : IPostService
    {
        private IPostDal _postDal;

        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }

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
        public Post Add(Post post)
        {
            return _postDal.Add(post);
        }

        [FluentValidationAspect(typeof(PostValidator))]
        public Post Update(Post post)
        {
            return _postDal.Update(post);
        }

        public void Delete(Post post)
        {
            _postDal.Delete(post);
        }
    }
}