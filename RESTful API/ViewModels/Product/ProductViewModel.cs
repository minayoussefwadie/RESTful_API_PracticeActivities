﻿using RESTful_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_API.ViewModels.Product
{
    public class ProductViewModel :ProductForMainpulationViewModel
    {
        public int ID { get; set; }
    }
}
