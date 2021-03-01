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

        public ActionResult Product(int id)
        {
            Product product = _iservices.GetById(id);
            return View(product);
        }
    }
}