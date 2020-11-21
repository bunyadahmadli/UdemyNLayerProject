﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UdemyNlayerProject.Core.Models;
using UdemyNlayerProject.Core.Repositories;

namespace UdemyNlayerProject.Data.Repositories
{
   public class ProductRepository:Repository<Product>,IProductRepository
    {
        private AppDbContext appDbContext
        {
            get
            {
                return _context as AppDbContext;
            }
        }


        public ProductRepository(DbContext context) : base(context)
        {
            
        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            return await appDbContext.Products.Include(x => x.Category).SingleOrDefaultAsync(x => x.Id == productId);
        }
    }
}
