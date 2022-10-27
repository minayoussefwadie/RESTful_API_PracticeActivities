using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_API.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        public string ImgURL { get; set; }
        [ForeignKey("CatID")]
        public virtual Category Category { get; set; }
        public int CatID { get; set; }

    }
}
