using MioBlog.Business.Abstracts;
using MioBlog.MvcWebUI.Models.Posts;
using System;
using System.Web.Mvc;
using MioBlog.MvcWebUI.Models;

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
            try
            {
                var model = new PostListModel
                {
                    Posts = _postService.GetAll()
                };

                return View(model);
            }
            catch (Exception exception)
            {
                TempData["authMessage"] = exception.Message;

                return View();
            }
        }
    }
}