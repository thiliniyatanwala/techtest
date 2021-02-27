using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Repository;

namespace  TechTest01.Services
{
    interface IUnitofWork
    {
        IProductRepository Product { get; }
    }
}
