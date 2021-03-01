using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain.Catalog;

namespace TechTest01.Repository
{
    public class ProductSeeder : CreateDatabaseIfNotExists<Contextdb>
    {
        protected override void Seed(Contextdb context)
        {

            Product product1 = new Product() { Name = "Red T Shirt", Price = 200, Slug = "Red-T-Shirt", ImageUrl = "/Images/red-t-shirt.jpg", Description = "This is a cotton red T shirt" };
            Product product2 = new Product() { Name = "Yello T Shirt", Price = 500, Slug = "Yellow-T-Shirt", ImageUrl = "/Images/yello-t-shirt.jpg", Description = "This is a linan yellow T shirt" };
            Product product3 = new Product() { Name = "Yello Cap", Price = 100, Slug = "Yello-Cap", ImageUrl = "/Images/yellow-cap.jpg", Description = "This is a cotton red Cap" };
            Product product4 = new Product() { Name = "Green scrf", Price = 600, Slug = "Green-scarf", ImageUrl = "/Images/green-scarf.jpg", Description = "This is a green synthetic scaf" };
            
            context.Product.Add(product1);
            context.Product.Add(product2);
            context.Product.Add(product3);
            context.Product.Add(product4);
            base.Seed(context);
           
        }
    }
}
