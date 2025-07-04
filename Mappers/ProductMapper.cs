using ProductApi.DTOs;
using ProductApi.Models;

namespace ProductApi.Mappers
{
    public class ProductMapper
    {
        public static Product ToProduct(ProductDto dto)
        {
            return new Product
            {
                Name = dto.Name,
                Price = dto.Price
            };
        }

        public static ProductDto ToDto(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };
        }
    }
}
