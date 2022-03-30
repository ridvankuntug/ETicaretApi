using ETicaretApi.Application.Repositories.IProduct;
using ETicaretApi.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Persistence.Repositories.Product
{
    internal class ProductReadRepository : ReadRepository<Domain.Entities.Product>, IProductReadRepository
    {
        public ProductReadRepository(ETicaretApiDbContext context) : base(context) { }
    }
}
