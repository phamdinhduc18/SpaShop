using SpaShop.ViewModels.Catalog.Products;
using SpaShop.ViewModels.Catalog.Products.Public;
using SpaShop.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpaShop.Domain.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<List<ProductViewModel>> GetAll();
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
