using KASHOP.DAL.Data;
using KASHOP.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KASHOP.DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<List<T>> GetAsync(Expression<Func<T,bool>>? filter = null,
            List<Expression<Func<T, Object>>>? includes = null ,
            bool tracked=false,
            CancellationToken cancellationToken = default)
        {
            IQueryable<T> query = _context.Set<T>().AsQueryable();
            if (!tracked)
                query = query.AsNoTracking();

            if(filter is not null)
                query = query.Where(filter);

            if(includes is not null)
            {
                foreach(var include in includes)
                    query = query.Include(include);
            }

            return await query.ToListAsync(cancellationToken);
            
        }

        public async Task<T?> GetOneAsync(Expression<Func<T, bool>>? filter = null,
            List<Expression<Func<T, Object>>>? includes = null,
            bool tracked = false,
            CancellationToken cancellationToken = default)
        {
            IQueryable<T> query = _context.Set<T>().AsQueryable();
            if (!tracked)
                query = query.AsNoTracking();

            if (filter is not null)
                query = query.Where(filter);

            if (includes is not null)
            {
                foreach (var include in includes)
                    query = query.Include(include);
            }

            return await query.FirstOrDefaultAsync(filter,cancellationToken);

        }

        public async Task CreateAsync(T entitiy, CancellationToken cancellationToken = default)
        {
            await _context.Set<T>().AddAsync(entitiy);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(T entitiy, CancellationToken cancellationToken = default) {
            _context.Set<T>().Update(entitiy);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task RemoveAsync(T entitiy, CancellationToken cancellationToken = default) {
            _context.Set<T>().Remove(entitiy);
            await _context.SaveChangesAsync(cancellationToken);
        }

    }
}
