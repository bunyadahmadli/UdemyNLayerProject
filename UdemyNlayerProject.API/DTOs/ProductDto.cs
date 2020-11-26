﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyNlayerProject.API.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} alanı gereklidir")]
        public string Name { get; set; }
        public int StockCode { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
   

    }
}
