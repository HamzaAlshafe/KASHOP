using KASHOP.DAL.Data;
using KASHOP.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
        
        public async Task<List<T>> GetAsync(CancellationToken cancellationToken = default)
        {
            var entities = await _context.Set<T>().AsNoTracking().ToListAsync();
            return entities;
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
