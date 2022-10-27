using RESTful_API.Models;
using RESTful_API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_API.Services
{
    public class ProductRepository:BaseRepository<Product>,IProductRepository
    {
        public ProductRepository(DataBaseContext dbcontext):base(dbcontext)
        {
        }
        public IQueryable<Product> GetByCatID(int id)
        {
            return GetAll().Where(p=>p.CatID==id);
        }
    }
}
