using System.Web.Mvc;

namespace NS.Elenalife.UI.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index()
        {
            return View("About");
        }
 
    }  
}