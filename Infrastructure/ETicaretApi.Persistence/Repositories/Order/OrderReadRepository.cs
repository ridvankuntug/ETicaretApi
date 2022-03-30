using ETicaretApi.Application.Repositories.IOrder;
using ETicaretApi.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Persistence.Repositories.Order
{
    internal class OrderReadRepository : ReadRepository<Domain.Entities.Order>, IOrderReadRepository
    {
        public OrderReadRepository(ETicaretApiDbContext context) : base(context) { }
    }
}
