using System.Collections.Generic;
using TechTest01.Domain.Catalog;
using TechTest01.Repository;

namespace TechTest01.Services.Catalog
{
    public interface IProductService
    {
        ICollection<Product> GetProducts();
        Product GetById(int id);
    }

    public class ProductServices : IProductService
    {
        UnitofWork unitofWork;
        public ProductServices()
        {
             this.unitofWork = new UnitofWork(new Contextdb());
        }

        public Product GetById(int id)
        {
            return unitofWork.Product.Get(id);          
        }

        public ICollection<Product> GetProducts()
        {
            return (ICollection<Product>)unitofWork.Product.GetAll();
        }
    }
}
