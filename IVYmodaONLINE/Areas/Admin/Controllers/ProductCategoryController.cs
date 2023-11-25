using IVYmodaONLINE.Models;
using IVYmodaONLINE.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IVYmodaONLINE.Areas.Admin.Controllers
{
    public class ProductCategoryController : Controller
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();
        // GET: Admin/ProductCategory
        public ActionResult Index()
        {
            var items = _dbContext.Productcategories.ToList();
            return View(items);
        }
        public ActionResult Add()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Productcategory model)
        {
            if (ModelState.IsValid)
            {
                model.createDate = DateTime.Now;
                model.Modifiedrdate = DateTime.Now;
                model.alias = IVYmodaONLINE.Models.Common.Filter.FilterChar(model.Title);
                _dbContext.Productcategories.Add(model);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}