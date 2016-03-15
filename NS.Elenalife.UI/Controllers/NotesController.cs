using System.Linq;
using System.Web.Mvc;

namespace NS.Elenalife.UI.Controllers
{
    public class NotesController : Controller
    {
        public ActionResult Index()
        {
            var db = new ElContext();
            var items = db.Posts.ToList();
            return View("Notes", items);
        }
 
    }
}