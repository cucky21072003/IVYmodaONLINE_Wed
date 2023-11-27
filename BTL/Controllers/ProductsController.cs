using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTL.Models;

namespace BTL.Controllers
{
    public class ProductsController : Controller
    {
        
        // GET: Products
        public ActionResult dmSP()
        {
            IVYmodaONLINEEntities db = new IVYmodaONLINEEntities();
            List<tb_Product> ketqua = db.tb_Product.ToList();
            return View();
        }
    }
}