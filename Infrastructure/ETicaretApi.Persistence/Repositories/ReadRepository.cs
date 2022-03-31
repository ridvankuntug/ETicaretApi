using ETicaretApi.Application.Repositories;
using ETicaretApi.Domain.Entities.Common;
using ETicaretApi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ETicaretApiDbContext _context;

        public ReadRepository(ETicaretApiDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table
            => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
            => tracking ? Table : Table.AsNoTracking();

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
            => tracking ? Table.Where(method) : Table.Where(method).AsNoTracking();

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
            => tracking ? 
            await Table.FirstOrDefaultAsync(method) : 
            await Table.AsQueryable().AsNoTracking().FirstOrDefaultAsync(method);

        public async Task<T> GetByIdAsync(string id, bool tracking = true)
            => tracking ?
            await Table.FindAsync(Guid.Parse(id)) :
            await Table.AsNoTracking().FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
    }
}
