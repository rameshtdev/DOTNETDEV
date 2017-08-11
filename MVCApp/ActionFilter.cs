using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Diagnostics;

namespace MVCApp
{
    public class LogActionFilter: ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            log("OnActionExecuted", filterContext.RouteData);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            log("OnActionExecuting", filterContext.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            log("OnResultExecuted", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            log("OnResultExecuting", filterContext.RouteData);
        }

        private void log(string methodname, RouteData routedata)
        {
            var controllerName = routedata.Values["controller"];
            var action = routedata.Values["action"];
            var message = string.Format("{0}-{1}-{2}", methodname, controllerName, action);
            Debug.WriteLine(message, "Action filter");
        }
    }
}