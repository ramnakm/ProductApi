using Microsoft.AspNetCore.Mvc;
using ProductApi.DTOs;
using ProductApi.Mappers;
using ProductApi.Services;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _service.GetAll().Select(ProductMapper.ToDto);
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _service.GetById(id);
            return product == null ? NotFound() : Ok(ProductMapper.ToDto(product));
        }

        [HttpPost]
        public IActionResult Create(ProductDto dto)
        {
            var product = _service.Create(dto);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, ProductMapper.ToDto(product));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ProductDto dto)
        {
            return _service.Update(id, dto) ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return _service.Delete(id) ? NoContent() : NotFound();
        }
    }
}
