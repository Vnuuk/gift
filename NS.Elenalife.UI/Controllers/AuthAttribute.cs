using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NS.Elenalife.UI.Controllers
{
    public class Auth : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string actionName = filterContext.ActionDescriptor.ActionName;
            string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            if(actionName.ToLower() == "login" && controllerName.ToLower() == "eladmin")
                return;

            var cookie = HttpContext.Current.Request.Cookies.Get("nselpac");
            if (cookie == null || cookie.Value == "" || cookie.Value != "#!corspolution")
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary
                            {
                                {"Controller", "Eladmin"},
                                {"Action", "Login"}
                            });
            }
        }
    }
}