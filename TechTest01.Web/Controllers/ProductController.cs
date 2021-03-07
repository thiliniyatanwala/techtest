using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTest01.Domain.Catalog;
using TechTest01.Services.Catalog;

namespace TechTest01.Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product

        private readonly IProductService _iservices;
        // GET: Home
        public ProductController(IProductService iservices)
        {
            _iservices = iservices;

        }
        public ActionResult Index()
        {
            ICollection<Product> product = _iservices.GetProducts();
            ViewBag.all = product;
            return View();
        }
 
        public ActionResult Product(string id)
        {
            int Rid=0;
            ICollection<Product> product = _iservices.GetProducts();
            foreach(Product single in product)
            {
                if (single.Slug == id)
                    Rid = single.Id;
            }

            Product products = _iservices.GetById(Rid);

            return View(products);
        }
    }
}