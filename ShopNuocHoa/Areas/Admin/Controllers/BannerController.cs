using ShopNuocHoa.Models;
using ShopNuocHoa.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopNuocHoa.Areas.Admin.Controllers
{
    
    public class BannerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Banner
        public ActionResult Index()
        {
            var items = db.Banners;
            return View(items);
        }
        
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Banner model)
        {
            if (ModelState.IsValid)
            {
                model.ModifiedDate = DateTime.Now;
                model.CreatedDate = DateTime.Now;

                db.Banners.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var items = db.Banners.Find(id);
            return View(items);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Banner model)
        {
            if (ModelState.IsValid) { 
                model.ModifiedDate = DateTime.Now;
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model) ;
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var items = db.Banners.Find(id);
            if (items != null) { 
                db.Banners.Remove(items);
                db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }

    }
}