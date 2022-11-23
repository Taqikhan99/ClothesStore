using ClothesStore_Entities;
using ClothesStore_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothesStore.Web.Controllers
{
    public class CategoryController : Controller
    {

        CategoriesService categoriesService= new CategoriesService();


        [HttpGet]
        public ActionResult Index()
        {
            List<Category> categories = categoriesService.GetCategories();
            return View(categories);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (category != null)
            {
                categoriesService.SaveCategory(category);
            }
            
            return RedirectToAction("Index");
        }
    }
}