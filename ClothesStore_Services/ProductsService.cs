using ClothesStore_Database;
using ClothesStore_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStore_Services
{
    public class ProductsService
    {

        //We will add db ref in service, service will call db not web directly
        public void SaveProduct(Product product)
        {
            using (var context = new StoreDbContext())
            {
                context.Products.Add(product);

                context.SaveChanges();

            }
        }

        public List<Product> GetProcucts()
        {
            using (var context = new StoreDbContext())
            {
                return context.Products.ToList();

            }
        }


        //getting one product
        public Product GetProduct(int Id)
        {
            using (var context = new StoreDbContext())
            {
                return context.Products.Find(Id);

            }
        }


        //edit category
        public void EditProduct(Product product)
        {
            using (var context = new StoreDbContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();

            }
        }

        public void DeleteProduct(Product product)
        {

            using (var context = new StoreDbContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Deleted;

                context.SaveChanges();

            }
        }
    }
}
