using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Util;

namespace MVCDemo.Filters
{
    public class CustomExceptionFilter : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            LogHelper.FileLogger.Error("自定义异常过滤器", filterContext.Exception);
            //TODO WriteLog
            base.OnException(filterContext);
        }
    }
}