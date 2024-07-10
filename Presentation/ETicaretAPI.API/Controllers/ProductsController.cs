using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            //await _productWriteRepository.AddRangeAsync(new()
            //{
            //    new() {Id = Guid.NewGuid(), Name = "Kazak", CreatedTime = DateTime.UtcNow, UnitPrice= 12, UnitsInStock = 10},
            //    new() {Id = Guid.NewGuid(), Name = "Gömlek", CreatedTime = DateTime.UtcNow, UnitPrice= 10, UnitsInStock = 20},
            //    new() {Id = Guid.NewGuid(), Name = "Ceket", CreatedTime = DateTime.UtcNow, UnitPrice= 100, UnitsInStock = 30},
            //});

            //var count = await _productWriteRepository.SaveAsync();

            //Product p = await _productReadRepository.GetByIdAsync("8bf2dfbb-8890-4905-a5a5-30c33a90e4dc", false);
            //p.Name = "Serkan";
            //await _productWriteRepository.SaveAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(String id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }

    }

}
