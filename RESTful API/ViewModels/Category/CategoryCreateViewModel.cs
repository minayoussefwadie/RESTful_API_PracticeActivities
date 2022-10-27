using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_API.ViewModels.Category
{
    public class CategoryCreateViewModel
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }
    }
}
