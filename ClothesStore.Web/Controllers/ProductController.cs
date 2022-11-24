using ClothesStore_Entities;
using ClothesStore_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothesStore.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductsService productsService = new ProductsService();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductTable()
        { 
            var p = productsService.GetProcucts();
            return PartialView(p);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (product != null)
            {
                productsService.SaveProduct(product);
            }

            return RedirectToAction("Index");
        }
    }
}