using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    [AllowAnonymous]
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            Exception ex = new Exception("你在逗我呢~~~哪有这个地址咯~~~");
            HandleErrorInfo info = new HandleErrorInfo(ex, this.GetType().ToString(), "404");
            return View("Error", info);
        }
    }
}