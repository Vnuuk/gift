using System;
using System.Web;
using System.Web.Mvc;

namespace NS.Elenalife.UI.Controllers
{
    [Auth]
    public class EladminController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(string password)
        {
            if (password == "!#$olalekan")
            {
                var cookie = new HttpCookie("nselpac", "#!corspolution");
                cookie.Expires = DateTime.Now.AddMinutes(2);
                Response.Cookies.Add(cookie);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Login");
        }
    }
}