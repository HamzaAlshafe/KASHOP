using KASHOP.DAL.DTO.Responses;
using KASHOP.DAL.DTO.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace KASHOP.BLL
{
    public interface ICategoryService
    {
        public Task<List<CategoryResponse>> GetAllAsync(CancellationToken cancellationToken = default);
        public Task<CategoryResponse?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        public Task<bool> CreateAsync(CategoryRequest request, CancellationToken cancellationToken = default);
        public Task<bool> UpdateAsync(CategoryRequest request, int id, CancellationToken cancellationToken = default);
        public Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default);
    }
}
