using IVYmodaONLINE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IVYmodaONLINE.Controllers
{
    public class MenuController : Controller
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MenuTop()
        {
            var items= _dbContext.Categories.OrderBy(x=>x.Position).ToList();
            return PartialView("_MenuTop");
        }
    }
}