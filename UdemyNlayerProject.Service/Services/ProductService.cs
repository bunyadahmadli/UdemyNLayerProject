using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UdemyNlayerProject.Core.Models;
using UdemyNlayerProject.Core.Service;
using UdemyNlayerProject.Core.UnitOfWorks;

namespace UdemyNlayerProject.Service.Services
{
   public class ProductService:IProductService
   {
       private readonly IUnitOfWork _unitOfWork;

       public ProductService(IUnitOfWork unitOfWork)
       {
           _unitOfWork = unitOfWork;
       }

       public async Task<Product> GetByIdAsync(int id)
       {
         return await _unitOfWork.Products.GetByIdAsync(id);
       }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
          return  await _unitOfWork.Products.GetAllAsync();
        }

        public async Task<IEnumerable<Product>> Where(Expression<Func<Product, bool>> predicate)
        {
            return await _unitOfWork.Products.Where(predicate);
        }

        public async Task<Product> SingleOrDefaultAsync(Expression<Func<Product, bool>> predicate)
        {
        return   await _unitOfWork.Products.SingleOrDefaultAsync(predicate);
        }

        public async Task<Product> AddAsync(Product entity)
        {
            await _unitOfWork.Products.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;
        }

        public async Task<IEnumerable<Product>> AddRangeAsync(IEnumerable<Product> entities)
        {
            await _unitOfWork.Products.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            return entities;
        }

        public void Remove(Product entity)
        {
            _unitOfWork.Products.Remove(entity);
            _unitOfWork.Commit();
        }

        public void RemoveRange(IEnumerable<Product> entities)
        {
            _unitOfWork.Products.RemoveRange(entities);
            _unitOfWork.Commit();

        }

        public Product Update(Product entity)
        {
           var updatedProduct= _unitOfWork.Products.Update(entity);
           _unitOfWork.Commit();
           return updatedProduct;
        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            return await _unitOfWork.Products.GetWithCategoryByIdAsync(productId);
        }
    }
}
