using RESTful_API.Models;
using RESTful_API.Repositories.Base;
using RESTful_API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_API.Repositories
{
   public interface IProductRepository:IRepository<Product>
    {
        IQueryable<Product> GetByCatID(int id);
    }
}
