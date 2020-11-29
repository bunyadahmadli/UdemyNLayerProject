using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using UdemyNlayerProject.Web.DTOs;
using UdemyNlayerProject.Core.Models;

namespace UdemyNlayerProject.Web.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<Category, CategoryWithProductDto>();
            CreateMap<CategoryWithProductDto, Category>();

            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
            CreateMap<Product, ProductWithCategoryDto>();
            CreateMap<ProductWithCategoryDto, Product>();

        }
    }
}
