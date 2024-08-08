using ShopNuocHoa.Models.EF;
using ShopNuocHoa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopNuocHoa.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin,Employee")]
    public class CategoryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Category

        public ActionResult Index()
        {
            var item = db.Categories;
            return View(item);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Category model)
        {
            // Kiểm tra có đúng định dạng
            if (ModelState.IsValid)
            {
                // Lấy thời gian hiện tại
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                //model.Alias = ShopNuocHoa.Models.Common.Filter.ChuyenCoDauThanhKhongDau(model.Title);
               // Thêm dữ liệu vào Category
                db.Categories.Add(model);
                db.SaveChanges();
                // trả về index
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public ActionResult Edit(int id)
        {
            // Lấy id
            var item = db.Categories.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category model)
        {
            // Kiểm tra có đúng định dạng
            if (ModelState.IsValid)
            {
                model.ModifiedDate = DateTime.Now;
                model.Alias = ShopNuocHoa.Models.Common.Filter.FilterChar(model.Title);
                // Giữ data hiện tại trên thanh input
                db.Categories.Attach(model);
                // Đánh dấu là data đã sửa và được cập nhật trong db
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.Categories.Find(id);
            if (item != null)
            {
                db.Categories.Remove(item);
                db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }

    }
}