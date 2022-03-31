using ETicaretApi.Application.Repositories.ICustomer;
using ETicaretApi.Application.Repositories.IOrder;
using ETicaretApi.Application.Repositories.IProduct;
using ETicaretApi.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;

        private readonly IOrderReadRepository _orderReadRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;

        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;

        public ProductsController(
            ICustomerReadRepository customerReadRepository, 
            ICustomerWriteRepository customerWriteRepository, 
            IOrderReadRepository orderReadRepository, 
            IOrderWriteRepository orderWriteRepository, 
            IProductReadRepository productReadRepository, 
            IProductWriteRepository productWriteRepository)
        {
            _customerReadRepository = customerReadRepository;
            _customerWriteRepository = customerWriteRepository;
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            //Guid customerId = Guid.NewGuid();
            //await _customerWriteRepository.AddAsync(new() { Id = customerId, Name = "test customer1"});

            //await _orderWriteRepository.AddAsync(new() { Description = "test order1", Address = "orhan ev", CustomerId = customerId});
            //await _orderWriteRepository.AddAsync(new() { Description = "test order2", Address = "mamak ev", CustomerId = customerId });
            //await _orderWriteRepository.SaveAsync();

            Order order = await _orderReadRepository.GetByIdAsync("47353e44-455c-4ff3-a323-8feaf64ed420");
            order.Address = "istanbul";
            await _orderWriteRepository.SaveAsync();
        }

    }
}
