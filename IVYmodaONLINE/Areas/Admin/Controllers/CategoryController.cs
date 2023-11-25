using IVYmodaONLINE.Models;
using IVYmodaONLINE.Models.EF;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IVYmodaONLINE.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();
        // GET: Admin/Category
        public ActionResult Index()
        {
            var items= _dbContext.Categories;
            return View(items);
        }
        public ActionResult Adđ() {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adđ(Category model)
        {
            if (ModelState.IsValid)
            {
                model.createDate = DateTime.Now;
                model.Modifiedrdate = DateTime.Now;
                model.Alias=IVYmodaONLINE.Models.Common.Filter.ChuyenCoDauThanhKhongDau(model.Title);
                _dbContext.Categories.Add(model);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var item = _dbContext.Categories.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category model)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Categories.Attach(model);
                model.Modifiedrdate = DateTime.Now;
                model.Alias = IVYmodaONLINE.Models.Common.Filter.ChuyenCoDauThanhKhongDau(model.Title);
                _dbContext.Entry(model).Property(x => x.Title).IsModified = true;
                _dbContext.Entry(model).Property(x => x.Description).IsModified = true;
                _dbContext.Entry(model).Property(x => x.Alias).IsModified = true;
                _dbContext.Entry(model).Property(x => x.SeoDescription).IsModified = true;
                _dbContext.Entry(model).Property(x => x.SeoKeyWords).IsModified = true;
                _dbContext.Entry(model).Property(x => x.Position).IsModified = true;
                _dbContext.Entry(model).Property(x => x.Modifiedrdate).IsModified = true;
                _dbContext.Entry(model).Property(x => x.ModifiedrBy).IsModified = true;
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = _dbContext.Categories.Find(id);
            if (item != null)
            {
                //var DeleteItem = _dbContext.Categories.Attach(item);
                _dbContext.Categories.Remove(item);
                _dbContext.SaveChanges();
                return Json(new {success=true});
            }    
            return Json(new {success=false});
        }
    }
}