using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using NS.Elenalife.UI.Models;

namespace NS.Elenalife.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Instagram()
        {
            var result = new List<PhotoVm>();
            using (var client = new WebClient())
            {
                var bytes = client.DownloadData("https://api.instagram.com/v1/users/471996769/media/recent/?access_token=35264441.8b94ff9.b401707386d646b3b0c043a4663de713");
                var info = Encoding.ASCII.GetString(bytes);

                var data = JObject.Parse(info).SelectToken("data").ToList();
                foreach (var obj in data)
                {
                    var title = obj.SelectToken("caption").HasValues ? obj.SelectToken("caption").SelectToken("text").ToString() : "";
                    var img = obj.SelectToken("images").SelectToken("standard_resolution").SelectToken("url").ToString();
                    result.Add(new PhotoVm { Title = title, Url = img });
                }

            }

            return View(result);
        }
    }
}