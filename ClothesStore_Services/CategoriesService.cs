using ClothesStore_Database;
using ClothesStore_Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStore_Services
{
    public class CategoriesService
    {
        
        //We will add db ref in service, service will call db not web directly
        public void SaveCategory(Category category)
        {
            using(var context= new StoreDbContext())
            {
                context.Categories.Add(category);
                
                context.SaveChanges();
                 
            }
        }

        public List<Category> GetCategories()
        {
            using (var context = new StoreDbContext())
            {
                return context.Categories.ToList();

            }
        }
    }
}
