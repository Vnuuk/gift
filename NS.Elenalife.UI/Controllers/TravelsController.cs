using System.Web.Mvc;

namespace NS.Elenalife.UI.Controllers
{
    public class TravelsController : Controller
    {
        public ActionResult Index()
        {
            return View("Travels");
        }

        public ActionResult Inner(int id)
        {
            return View("Details");
        }
    }
}