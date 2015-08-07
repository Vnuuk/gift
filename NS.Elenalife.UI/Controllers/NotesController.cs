using System.Web.Mvc;

namespace NS.Elenalife.UI.Controllers
{
    public class NotesController : Controller
    {
        public ActionResult Index()
        {
            return View("Notes");
        }
 
    }
}