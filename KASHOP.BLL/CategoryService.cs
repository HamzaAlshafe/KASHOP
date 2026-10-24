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

        public List<CategoryResponse> GetAll()
        {
            var categories = _repo.Get();
            return categories.Adapt<List<CategoryResponse>>();
            
        }

        public bool Create(CategoryRequest request)
        {
            var exisits = _repo.Get().Any(c => c.Name.ToLower() == request.Name.ToLower());
            if (exisits) return false;

            var category = request.Adapt<Category>();
            _repo.Create(category);
            return true;
        }

        public CategoryResponse? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(CategoryRequest request, int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
