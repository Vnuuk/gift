using System.Web.Mvc;

namespace NS.Elenalife.UI.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public ActionResult CreateTravel()
        {
            return View("AddEditTravel");
        }
    }
}