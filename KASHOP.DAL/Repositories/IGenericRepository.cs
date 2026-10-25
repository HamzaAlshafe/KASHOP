using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KASHOP.DAL.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task CreateAsync (T entity, CancellationToken cancellationToken = default);
        Task UpdateAsync(T entity, CancellationToken cancellationToken = default);
        Task RemoveAsync(T entity, CancellationToken cancellationToken = default);
        Task<List<T>> GetAsync(Expression<Func<T, bool>>? filter = null,
            List<Expression<Func<T, Object>>>? includes = null,
            bool tracked = false,
            CancellationToken cancellationToken = default);
        Task<T?> GetOneAsync(Expression<Func<T, bool>>? filter = null,
            List<Expression<Func<T, Object>>>? includes = null,
            bool tracked = false,
            CancellationToken cancellationToken = default);
    }
}
