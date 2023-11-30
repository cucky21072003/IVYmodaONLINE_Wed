using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IVYmodaONLINE.Models;

namespace IVYmodaONLINE.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext dbContext = new ApplicationDbContext();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Partial_ItemsByCateId(int cateid)
        {
            var items = dbContext.Products.Where(x => x.ProductCategoryId == cateid).ToList();
            return PartialView(items);
        }
    }
}