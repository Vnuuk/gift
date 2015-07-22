using System.Web.Mvc;

namespace NS.Elenalife.UI.Controllers
{
    public class TravelController : Controller
    {
        public ActionResult Posters()
        {
            return View("Posters");
        }
    }
}