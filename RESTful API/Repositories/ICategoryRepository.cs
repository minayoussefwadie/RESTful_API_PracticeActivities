using RESTful_API.Models;
using RESTful_API.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_API.Repositories
{
    public interface ICategoryRepository:IRepository<Category>
    {
    }
}
