using SpaShop.Domain.Catalog.Dtos;

namespace SpaShop.Domain.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest: PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
