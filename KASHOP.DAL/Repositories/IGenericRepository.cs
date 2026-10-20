using System;
using System.Collections.Generic;
using System.Text;

namespace KASHOP.DAL.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        void Create (T entity);
        void Update (T entity);
        void Remove (T entity);
        List<T> Get();
    }
}
