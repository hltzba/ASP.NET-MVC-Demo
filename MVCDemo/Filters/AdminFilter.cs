using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Filters
{
    public class AdminFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["IsAdmin"] == null || Convert.ToBoolean(filterContext.HttpContext.Session["IsAdmin"]) == false)
            {
                filterContext.Result = new ContentResult()
                {
                    Content = "未经授权的用户"
                };
            }
            else
            {
                base.OnActionExecuting(filterContext);
            }
        }
    }
}