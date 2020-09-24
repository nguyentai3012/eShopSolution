using eShopSolution.Application.Catalog.DTOs;
using eShopSolution.Application.Catalog.Products.DTO;
using eShopSolution.Application.Catalog.Products.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductCreateRequest request);
        Task<int> Delete(int ProductId);
        Task<List<ProductViewModel>> GetAll();
        Task<PagedViewModel<ProductViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize);
    }
}
