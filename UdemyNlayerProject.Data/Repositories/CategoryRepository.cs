using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UdemyNlayerProject.Core.Models;
using UdemyNlayerProject.Core.Repositories;

namespace UdemyNlayerProject.Data.Repositories
{
    class CategoryRepository:Repository<Category>,ICategoryRepository
    {
        private AppDbContext _appDbContext {get => _context as AppDbContext;}
        public CategoryRepository(DbContext context) : base(context)
        {
        }

        public async Task<Category> GetWithProductByIdAsync(int categoryId)
        {
            return await _appDbContext.Categories.Include(x => x.Products)
                .SingleOrDefaultAsync(x => x.Id == categoryId);
        }
    }
}
