using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MioBlog.Business.Abstracts;
using MioBlog.Core.CrossCuttingConcerns.Security.Web;

namespace MioBlog.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userName, string password, bool rememberMe = true)
        {
            var userControl = _userService.GetByUserNameAndPassword(userName, password);

            if (userControl != null)
            {
                AuthenticationHelper.CreateAuthCookie(
                    new Guid(), userControl.UserName, userControl.Email, DateTime.Now.AddDays(15),
                    _userService.GetUserRoles(userControl).Select(u => u.RoleName).ToArray()
                    , rememberMe, userControl.FirstName, userControl.LastName
                    );

                return RedirectToAction("Index", "Post");
            }

            TempData["message"] = "user not found";
            return View();
        }

    }
}