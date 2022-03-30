﻿
using ETicaretApi.Domain.Entities.Common;

namespace ETicaretApi.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> datas);

        bool Update(T model);

        bool Remove(T model);
        bool RemoveRange(List<T> datas);
        Task<bool> RemoveAsync(string id);

        Task<int> SaveAsync();

    }
}
