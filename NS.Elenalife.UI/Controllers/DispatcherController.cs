using Incoding.MvcContrib.MVD;
using NS.Elenalife.Domain;

namespace NS.Elenalife.UI.Controllers
{
    public class DispatcherController : DispatcherControllerBase
    {
        public DispatcherController() : base(typeof(Bootstrapper).Assembly) { }
    }
}