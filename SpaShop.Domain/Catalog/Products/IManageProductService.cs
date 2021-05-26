using SpaShop.Domain.Catalog.Dtos;
using SpaShop.Domain.Catalog.Products.Dtos;
using SpaShop.Domain.Catalog.Products.Dtos.Manage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaShop.Domain.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task AddViewcount(int productId);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
    }
}
