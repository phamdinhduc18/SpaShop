using SpaShop.ViewModels.Catalog.ProductImages;
using SpaShop.ViewModels.Catalog.Products;
using SpaShop.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpaShop.Domain.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<List<ProductViewModel>> GetAll(string languageId);
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);
    }
}
