using ShopNuocHoa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopNuocHoa.Controllers
{
    public class AboutUsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: AboutUs
        public ActionResult Index()
        {
            var items = db.Posts.FirstOrDefault();
            return View(items);
        }
    }
}