using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NS.Elenalife.UI.Controllers
{
    [Auth]
    public class EladminController : Controller
    {
        public ActionResult Index()
        {
            var posts = new ElContext().Posts.Where(r => r.Active).ToList();

            return View("Index", posts);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(string password)
        {
            if (password == "test")
            {
                var cookie = new HttpCookie("nselpac", "#!corspolution");
                cookie.Expires = DateTime.Now.AddMinutes(2);
                Response.Cookies.Add(cookie);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Login");
        }

        [HttpGet]
        public ActionResult EditPost(int id)
        {
            var post = new ElContext().Posts.First(r => r.Id == id);
            return View("EditPost", post);
        }

        [HttpPost]
        public ActionResult EditPost(Post item)
        {
            var context = new ElContext();
            var post = context.Posts.First(r => r.Id == item.Id);
            post.Title = item.Title;
            post.Text = item.Text;
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddPost()
        {
            return View("AddPost");
        }

        [HttpPost]
        public ActionResult AddPost(PostInput item)
        {
            var context = new ElContext();
            var post = new Post();
            post.Title = item.Title;
            post.Text = item.Text;
            post.DateTime = DateTime.Now;
            post.Active = true;

            var guid = Guid.NewGuid();
            item.Image.SaveAs(Server.MapPath(" ") + @"\img\posts\" + guid + ".jpg");
            post.Images.Add(new Image { Path = Server.MapPath(" ") + @"\img\posts\" + guid + ".jpg", PostId = post.Id });

            context.Posts.Add(post);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult MarkInactive(int id)
        {
            var context = new ElContext();
            var post = context.Posts.First(r => r.Id == id);
            post.Active = false;
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}