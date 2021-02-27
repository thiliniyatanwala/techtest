using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Repository;

namespace TechTest01.Services
{
    public class UnitofWork : IUnitofWork
    {
        private Contextdb _Context;

        public UnitofWork(Contextdb context)
        {
            _Context = context;
            Product = new ProductRepository(_Context);
        }
        public IProductRepository Product { get; set; }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
