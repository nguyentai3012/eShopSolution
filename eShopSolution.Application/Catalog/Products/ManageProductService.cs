using eShopSolution.Application.Catalog.Products.DTO;
using eShopSolution.Application.Catalog.Products.DTOs;
using eShopSolution.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {
        private readonly EShopDbContext _context;
        public ManageProductService(EShopDbContext context)
        {
            _context = context;
        }
        int IManageProductService.Create(ProductCreateRequest request)
        {
            throw new NotImplementedException();
        }

        int IManageProductService.Delete(int ProductId)
        {
            throw new NotImplementedException();
        }

        List<ProductViewModel> IManageProductService.GetAll()
        {
            throw new NotImplementedException();
        }

        List<ProductViewModel> IManageProductService.GetAllPaging(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        int IManageProductService.Update(ProductCreateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
