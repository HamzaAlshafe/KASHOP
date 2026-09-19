using KASHOP.DAL.Data;
using KASHOP.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KASHOP.DAL.Repositories
{
    public class GenericRepository<T> where T : class
    {
        ApplicationDbContext context = new ApplicationDbContext();
        
        public List<T> Get()
        {
            var entities = context.Set<T>().AsNoTracking().ToList();
            return entities;
        }

        public void Create(T entitie)
        { 
            context.Set<T>().Add(entitie);
            context.SaveChanges();
        }

        public void Update(T entitie) {
            context.Set<T>().Update(entitie);
            context.SaveChanges();
        }

        public void Remove(T entitie) { 
            context.Set<T>().Remove(entitie);
            context.SaveChanges();
        }

    }
}
