using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;
using System.Web.Security;

namespace MVCDemo.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoLogin(UserDetailsViewModel user)
        {
            if (ModelState.IsValid)
            {
                if (user.UserName == "admin" && user.Password == "admin")
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                    Session["IsAdmin"] = true;
                    return RedirectToAction("Index", "Employee");
                }
                else if (user.UserName == "jimmy" && user.Password == "123")
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                    Session["IsAdmin"] = false;
                    return RedirectToAction("Index", "Employee");
                }
                else
                {
                    ModelState.AddModelError("CredentialError", "用户名或密码错误");
                    return View("Login");
                }
            }
            else
            {
                return View("Login");
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}