using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UdemyNlayerProject.Core.Models;
using UdemyNlayerProject.Core.Repositories;
using UdemyNlayerProject.Core.Service;
using UdemyNlayerProject.Core.UnitOfWorks;

namespace UdemyNlayerProject.Service.Services
{
    public class ProductService : Service<Product>,IProductService
    {
        public ProductService(IRepository<Product> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
          return await _unitOfWork.Products.GetWithCategoryByIdAsync(productId);
        }
    }
}
