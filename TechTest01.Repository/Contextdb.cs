using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain.Catalog;

namespace TechTest01.Repository
{
    public class Contextdb : DbContext
    {
     public Contextdb(): base("name =ProductConString")
            {
                this.Configuration.LazyLoadingEnabled = false;
            }

            public virtual DbSet<Product> Product { get; set; }

    }
}
