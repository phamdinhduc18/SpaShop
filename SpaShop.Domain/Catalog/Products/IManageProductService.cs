
using Microsoft.AspNetCore.Http;
using SpaShop.ViewModels.Catalog.Products;
using SpaShop.ViewModels.Common;
using System.Collections.Generic;
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
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);
        Task<int> AddImages(int productId, List<IFormFile> files);

        Task<int> RemoveImages(int imageId);

        Task<int> UpdateImage(int imageId, string caption, bool isDefault);
        Task<List<ProductImageViewModel>> GetListImage(int productId);
    }
}
