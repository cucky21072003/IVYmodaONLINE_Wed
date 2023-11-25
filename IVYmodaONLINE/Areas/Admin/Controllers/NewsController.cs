using IVYmodaONLINE.Models;
using IVYmodaONLINE.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IVYmodaONLINE.Areas.Admin.Controllers
{
    public class NewsController : Controller
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();
        // GET: Admin/News
        public ActionResult Index()
        {
            var items=_dbContext.News.OrderByDescending(x=>x.Id).ToList();
            return View(items);
        }

        public ActionResult Add() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(New model)
        {
            if (ModelState.IsValid)
            {
                model.createDate = DateTime.Now;
                model.CategoryId = 9;
                model.Modifiedrdate = DateTime.Now;
                model.Alias = IVYmodaONLINE.Models.Common.Filter.FilterChar(model.Title);
                _dbContext.News.Add(model);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var item = _dbContext.News.Find(id);
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(New model)
        {
            if (ModelState.IsValid)
            {
                model.Modifiedrdate = DateTime.Now;
                model.Alias = IVYmodaONLINE.Models.Common.Filter.FilterChar(model.Title);
                _dbContext.News.Attach(model);
                _dbContext.Entry(model).State = System.Data.Entity.EntityState.Modified;
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            var item= _dbContext.News.Find(id);
            if (item != null)
            {
                _dbContext.News.Remove(item);
                _dbContext.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}