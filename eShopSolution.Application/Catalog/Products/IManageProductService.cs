using eShopSolution.Application.Catalog.Products.DTO;
using eShopSolution.Application.Catalog.Products.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        int Create(ProductCreateRequest request);
        int Update(ProductCreateRequest request);
        int Delete(int ProductId);
        List<ProductViewModel> GetAll();
        List<ProductViewModel> GetAllPaging(string keyword, int pageIndex, int pageSize);
    }
}
