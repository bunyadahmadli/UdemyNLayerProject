﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyNlayerProject.Web.DTOs
{
    public class ProductWithCategoryDto:ProductDto
    {
        public CategoryDto Category { set; get; }
    }
}
