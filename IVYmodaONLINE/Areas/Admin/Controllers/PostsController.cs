using IVYmodaONLINE.Models.EF;
using IVYmodaONLINE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IVYmodaONLINE.Areas.Admin.Controllers
{
    public class PostsController : Controller
    {
        // GET: Admin/Posts
        private ApplicationDbContext _dbContext = new ApplicationDbContext();

        public ActionResult Index()
        {
            var items = _dbContext.Posts.OrderByDescending(x => x.Id).ToList();
            return View(items);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Post model)
        {
            if (ModelState.IsValid)
            {
                model.createDate = DateTime.Now;
                model.CategoryId = 1;
                model.Modifiedrdate = DateTime.Now;
                model.Alias = IVYmodaONLINE.Models.Common.Filter.FilterChar(model.Title);
                _dbContext.Posts.Add(model);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var item = _dbContext.Posts.Find(id);
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Post model)
        {
            if (ModelState.IsValid)
            {
                model.Modifiedrdate = DateTime.Now;
                model.Alias = IVYmodaONLINE.Models.Common.Filter.FilterChar(model.Title);
                _dbContext.Posts.Attach(model);
                _dbContext.Entry(model).State = System.Data.Entity.EntityState.Modified;
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            var item = _dbContext.Posts.Find(id);
            if (item != null)
            {
                _dbContext.Posts.Remove(item);
                _dbContext.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}