using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MioBlog.Business.Abstracts;
using MioBlog.Entities.Concretes;

namespace MioBlog.WebApi.Controllers
{
    public class PostsController : ApiController
    {
        private IPostService _postService;

        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        public List<Post> Get()
        {
            return _postService.GetAll();
        }
    }
}
