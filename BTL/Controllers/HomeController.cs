using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTL.Models;

namespace BTL.Controllers
{

    public class HomeController : Controller
    {

        //Trang home
        public ActionResult Index()
        {
            return View();
        }
        //tách ra chia trang 
        public ActionResult VeChungToi()
        { 
            return View();
        }
        //Login vs register nó nằm trong layout lấy dữ liệu từ database
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        //Sale để riêng 1 trang
        public ActionResult Sale()
        {
            
            return View();
        }
        public ActionResult lifestyle()
        {
            return View();
        }
        //để riêng 1 trang lấy dữ liệu của bảng product r sau đó gửi về layout product và Home
        //muốn lấy đc dữ liệu từ Product phải kết xuất từ thằng database ra

        public ActionResult Product()
        {
            return View();
        }

       
        private readonly List<tb_Product> _products = new List<tb_Product>
    {
        new tb_Product { Id = 1, Title = "Product 1", Price = 10.99m },
        new tb_Product { Id = 2, Title = "Product 2", Price = 20.49m },
        // Add more products as needed
    };

       
        public ActionResult Cart(int productId)
        {
            // Assume there is a session variable for the cart
            tb_Order cart = Session["Cart"] as tb_Order ?? new tb_Order();

            // Find the product by Id
            tb_Product product = _products.FirstOrDefault(p => p.Id == productId);



            // Update the session variable
            Session["Cart"] = cart;

            // Redirect back to the product list or cart page
            return RedirectToAction("Index");
            
        }
        // áo kiểu nam nữ này đều thuộc bảng product cả gửi data tới nó là đc
        public ActionResult Nu_aokieu()
        {
            return View();
        }
        public ActionResult Nu_aocrop()
        {
            return View();
        }
        public ActionResult Nam_aothun()
        {
            return View();
        }
        public ActionResult Nam_aosomi()
        {
            return View();
        }
        public ActionResult BeTrai_quanao()
        {
            return View();
        }
        public ActionResult BeGai_quanao()
        {
            return View();
        }
        
    }
}