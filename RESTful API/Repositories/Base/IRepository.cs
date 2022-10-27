using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_API.Repositories.Base
{
    public interface IRepository<T>where T:class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        IQueryable<T> GetAll();
    }
}
