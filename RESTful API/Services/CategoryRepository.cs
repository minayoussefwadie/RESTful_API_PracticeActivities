using RESTful_API.Models;
using RESTful_API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_API.Services
{
    public class CategoryRepository:BaseRepository<Category>,ICategoryRepository
    {
        public CategoryRepository(DataBaseContext dbcontext):base(dbcontext)
        {
        }
    }
}
