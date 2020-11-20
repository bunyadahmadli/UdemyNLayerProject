using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNlayerProject.Core.Models;

namespace UdemyNlayerProject.Core.Service
{
  public interface ICategoryService:IService<Category>
    {
        Task<Category> GetWithProductByIdAsync(int categoryId);
    }
}
