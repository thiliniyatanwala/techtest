using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using TechTest01.Domain;
using TechTest01.Domain.Catalog;

namespace TechTest01.Repository
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
    }

    public interface IProductRepository : IRepository<Product>
    {
       
    }

    public class ProductRepository : Repository<Product>,IProductRepository
    {
        public ProductRepository(Contextdb context) : base(context)
        {

        }

        public Contextdb Contextdb
        {
            get { return Context as Contextdb; }
        }

    }

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity {

        protected DbContext Context;

        public Repository(DbContext context) {
            Context = context;
        }
        
        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToArray();
        }
    }
}
