using KASHOP.DAL.DTO.Requests;
using KASHOP.DAL.DTO.Responses;
using KASHOP.DAL.Models;
using KASHOP.DAL.Repositories;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace KASHOP.BLL
{
    public class CategoryService : ICategoryService
    {
        private readonly IGenericRepository<Category> _repo;
        public CategoryService(IGenericRepository<Category> repo)
        {
            _repo = repo;
        }

        public async Task<List<CategoryResponse>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var categories = await _repo.GetAsync(cancellationToken);
            return categories.Adapt<List<CategoryResponse>>();
            
        }

        public async Task<bool> CreateAsync(CategoryRequest request, CancellationToken cancellationToken = default)
        {

            // Fix This proplem later
            //var exisits = _repo.GetAsync().Any(c => c.Name.ToLower() == request.Name.ToLower());
            //if (exisits) return false;

            var category = request.Adapt<Category>();
            await _repo.CreateAsync(category, cancellationToken);
            return true;
        }

        public async Task<CategoryResponse?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(CategoryRequest request, int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default) 
        {
            throw new NotImplementedException();
        }
    }
}
