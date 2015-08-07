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
            //if moscow
            if(id == 1)
                return View("Details");

            return View("DetailsKazan");
        }
    }
}