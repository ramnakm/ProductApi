using ProductApi.DTOs;
using ProductApi.Models;
using ProductApi.Repositories;

using ProductApi.Mappers;
namespace ProductApi.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Product> GetAll() => _repository.GetAll();

        public Product? GetById(int id) => _repository.GetById(id);

        public Product Create(ProductDto dto)
        {
            var product = ProductMapper.ToProduct(dto);
            _repository.Add(product);
            return product;
        }

        public bool Update(int id, ProductDto dto)
        {
            var existing = _repository.GetById(id);
            if (existing is null) return false;

            existing.Update(dto.Name, dto.Price);
            _repository.Update(existing);
            return true;
        }

        public bool Delete(int id)
        {
            var existing = _repository.GetById(id);
            if (existing is null) return false;

            _repository.Delete(id);
            return true;
        }
    }
}
