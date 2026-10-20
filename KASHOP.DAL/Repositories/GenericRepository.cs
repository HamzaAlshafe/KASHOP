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
        
        public List<T> Get()
        {
            var entities = _context.Set<T>().AsNoTracking().ToList();
            return entities;
        }

        public void Create(T entitie)
        {
            _context.Set<T>().Add(entitie);
            _context.SaveChanges();
        }

        public void Update(T entitie) {
            _context.Set<T>().Update(entitie);
            _context.SaveChanges();
        }

        public void Remove(T entitie) {
            _context.Set<T>().Remove(entitie);
            _context.SaveChanges();
        }

    }
}
