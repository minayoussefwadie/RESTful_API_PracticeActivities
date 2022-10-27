using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_API.Models
{
    public abstract class ProductForMainpulationViewModel
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        public string ImgURL { get; set; }
        [Required]
        public int CatID { get; set; }
    }
}
