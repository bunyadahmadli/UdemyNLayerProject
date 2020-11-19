using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNlayerProject.Core.Models;

namespace UdemyNlayerProject.Core.Repositories
{
    interface ICategoryRepository:IRepository<Category>
    {
        Task<Category> GetWithProductByIdAsync(int categoryId);

    }
}
