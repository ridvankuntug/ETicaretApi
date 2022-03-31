using ETicaretApi.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ETicaretApi.Application.Repositories.ICustomer;
using ETicaretApi.Persistence.Repositories.Customer;
using ETicaretApi.Application.Repositories.IOrder;
using ETicaretApi.Application.Repositories.IProduct;
using ETicaretApi.Persistence.Repositories.Product;
using ETicaretApi.Persistence.Repositories.Order;

namespace ETicaretApi.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretApiDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
