using ETicaretApi.Application.Repositories.IProduct;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }
        [HttpGet]
        public async void Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new() { Id = Guid.NewGuid(), Name = "product1", Price = 111, CreatedDate = DateTime.UtcNow, Stock = 10},
                new() { Id = Guid.NewGuid(), Name = "product2", Price = 112, CreatedDate = DateTime.UtcNow, Stock = 20},
                new() { Id = Guid.NewGuid(), Name = "product3", Price = 113, CreatedDate = DateTime.UtcNow, Stock = 30},
                new() { Id = Guid.NewGuid(), Name = "product4", Price = 114, CreatedDate = DateTime.UtcNow, Stock = 40}
            });
            await _productWriteRepository.SaveAsync();
        }
    }
}
