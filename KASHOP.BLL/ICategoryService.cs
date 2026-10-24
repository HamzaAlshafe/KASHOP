using KASHOP.DAL.DTO.Responses;
using KASHOP.DAL.DTO.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace KASHOP.BLL
{
    public interface ICategoryService
    {
        public List<CategoryResponse> GetAll();
        public CategoryResponse? GetById(int id);
        bool Create(CategoryRequest request);
        bool Update(CategoryRequest request, int id);
        bool Delete(int id);
    }
}
