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


        //list all categories
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


        //Edit category
        [HttpGet]
        public ActionResult Edit(int Id) {
        
            var cat= categoriesService.GetCategory(Id);
            if(cat!=null)
                return View(cat);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoriesService.EditCategory(category);
            return RedirectToAction("Index");

        }

        //deleting
        [HttpGet]
        public ActionResult Delete(int Id)
        {

            var cat = categoriesService.GetCategory(Id);
            return View(cat);
        }

        [HttpPost]
        public ActionResult Delete(Category c)
        {
            var cat = categoriesService.GetCategory(c.ID);
            categoriesService.DeleteCategory(cat);
            return RedirectToAction("Index");

        }
    }
}