using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_API.ViewModels.Product
{
    public class Mappings:Profile
    {
       public Mappings()
        {
            CreateMap<Models.Product, ProductViewModel>();
            CreateMap<ProductUpdateViewModel, Models.Product>();
        }
    }
}
