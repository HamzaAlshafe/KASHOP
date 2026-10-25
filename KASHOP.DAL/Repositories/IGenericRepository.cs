using System;
using System.Collections.Generic;
using System.Text;

namespace KASHOP.DAL.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task CreateAsync (T entity, CancellationToken cancellationToken = default);
        Task UpdateAsync(T entity, CancellationToken cancellationToken = default);
        Task RemoveAsync(T entity, CancellationToken cancellationToken = default);
        Task <List<T>> GetAsync(CancellationToken cancellationToken = default);
    }
}
