using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RESTful_API.Models;
using RESTful_API.Repositories;
using RESTful_API.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController:ControllerBase
    {
        private readonly IProductRepository ProductRepository;
        private readonly ICategoryRepository CategoryRepository;

        IMapper _Mapper;
        public ProductController(IProductRepository ProductRepository, ICategoryRepository CategoryRepository, IMapper _Mapper)
        {
            this.ProductRepository = ProductRepository;
            this.CategoryRepository = CategoryRepository;
            this._Mapper = _Mapper;
        }
        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                ProductRepository.Add(product);
                return CreatedAtRoute("getproductByID",new {id= product .ID}, product);
            }
            return ValidationProblem(ModelState);
        }
        [HttpGet]
        public ActionResult getAllproducts(int categoryId)
        {
            List<ProductViewModel> res = null;
            var list = ProductRepository.GetAll().ToList();

            if (CategoryRepository.GetById(categoryId) != null)
                list=ProductRepository.GetByCatID(categoryId).ToList();

            res= _Mapper.Map(list, res);
            return Ok(res);
        }
        [HttpGet("{id}",Name = "getproductByID")]
        public ActionResult getproductByID(int id)
        {
            if (ProductRepository.GetById(id) !=null)
            {
                var item = ProductRepository.GetById(id);
                ProductViewModel res = null;
                res = _Mapper.Map(item, res);
                return Ok(res);
            }
            return NotFound();
        }
        [HttpPut("{id}")]
        public ActionResult updateProduct(int id, ProductUpdateViewModel productforUpdate)
        {
            var product = ProductRepository.GetById(id);
            if (product == null)
                return NotFound();

            if (!TryValidateModel(productforUpdate))
                return ValidationProblem(ModelState);

            product= _Mapper.Map(productforUpdate, product);
            ProductRepository.Update(product);

            var res = _Mapper.Map(product,new ProductViewModel());
            return CreatedAtRoute("getproductByID", new { id = product.ID }, res);
         }
    }
}
