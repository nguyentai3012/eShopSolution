using eShopSolution.Application.Catalog.DTOs;
using eShopSolution.Application.Catalog.Products.DTO;
using eShopSolution.Application.Catalog.Products.DTOs;
using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {
        private readonly EShopDbContext _context;
        public ManageProductService(EShopDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// create product 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product() {
                Price = request.Price,
            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public Task<int> Delete(int ProductId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PagedViewModel<ProductViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(ProductCreateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
