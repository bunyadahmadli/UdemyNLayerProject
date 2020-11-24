using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNlayerProject.Core.Models;
using UdemyNlayerProject.Core.Repositories;
using UdemyNlayerProject.Core.Service;
using UdemyNlayerProject.Core.UnitOfWorks;

namespace UdemyNlayerProject.Service.Services
{
   public class CategoryService:Service<Category>,ICategoryService
   
   {
       public CategoryService(IRepository<Category> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
       {
       }

       public async Task<Category> GetWithProductByIdAsync(int categoryId)
       {
           return await _unitOfWork.Categories.GetWithProductByIdAsync(categoryId);
       }
   }
}
