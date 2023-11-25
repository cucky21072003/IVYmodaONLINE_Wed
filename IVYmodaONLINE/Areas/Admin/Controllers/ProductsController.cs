using IVYmodaONLINE.Models;
using IVYmodaONLINE.Models.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IVYmodaONLINE.Areas.Admin.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();
        // GET: Admin/Product
        public ActionResult Index(int? page)
        {
            IEnumerable<Product> items = _dbContext.Products.OrderByDescending(x=>x.Id);
            var pageSize = 10;
            if(page == null)
            {
                page = 1;
            }
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            items= items.ToPagedList(pageIndex, pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.Page=page;
            return View();
        }
        public ActionResult Add()
        {
            ViewBag.ProductCategory = new SelectList(_dbContext.Productcategories.ToList(), "Id", "Title");
            return View();
        }
    }
}