using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTest01.Domain.Catalog;
using TechTest01.Services.Catalog;

namespace TechTest01.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly IProductService _iservices;
        // GET: Home
        public HomeController(IProductService iservices) {
            _iservices = iservices;

                }
        public ActionResult Index()
        {
            ICollection<Product> product = _iservices.GetProducts();
            Random randomnum = new Random();
            int rInt = randomnum.Next(0,product.Count);
            int rInt2;
            do {
                rInt2 = randomnum.Next(0, product.Count);
            } while (rInt == rInt2);
            List<Product> product1 = new List<Product>();
            product1.Add(product.ToArray()[rInt]);
            product1.Add(product.ToArray()[rInt2]);
            ViewBag.index = product1;
            return View();
        }

      
    }
}