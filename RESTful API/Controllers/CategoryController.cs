using Microsoft.AspNetCore.Mvc;
using RESTful_API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_API.Controllers
{
   
    [ApiController]
    [Route("[controller]")]
    public class CategoryController:ControllerBase
    {
        private readonly ICategoryRepository CategoryRepository;

        public CategoryController(ICategoryRepository CategoryRepository)
        {
            this.CategoryRepository = CategoryRepository;
        }
        [HttpGet]
        public ActionResult getAllCategories()
        {
            var list = CategoryRepository.GetAll().ToList();
            return Ok(list);
        }

    }
}
