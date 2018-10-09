using MioBlog.Business.Abstracts;
using MioBlog.MvcWebUI.Models.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MioBlog.MvcWebUI.Controllers
{
    public class PostController : Controller
    {
        private IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        // GET: Post
        public ActionResult Index()
        {
            var model = new PostListModel
            {
                Posts = _postService.GetAll()
            };

            return View(model);
        }
    }
}