﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_API.Models
{
    public class Category
    {
        [Key]
        public int CatID { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
    }
}
