using KASHOP.BLL.Settings;
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
            var categories = await _repo.GetAsync(
                includes: [c=>c.Translations],
                cancellationToken: cancellationToken);
            return categories.Adapt<List<CategoryResponse>>();
            
        }

        public async Task<bool> CreateAsync(CategoryRequest request, CancellationToken cancellationToken = default)
        {

            if (!AreTranslationsValid(request.Translations)) return false;

            var names = request.Translations.Select(n => n.Name.ToLower()).ToList();
            var existing = await _repo.GetOneAsync(
                filter: c => c.Translations.Any(t => names.Contains(t.Name.ToLower()))
                ,cancellationToken: cancellationToken);

            if (existing is not null) return false;

            var category = request.Adapt<Category>();
            await _repo.CreateAsync(category, cancellationToken: cancellationToken);
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
        private static bool AreTranslationsValid(List<CategoryTranslationRequest> translations)
        {

            var languages = translations.Select(x => x.Language).ToList();

            if (languages.Distinct().Count() != languages.Count()) return false;

            return languages.Count() == SupportedLanguages.Languages.Length
                && SupportedLanguages.Languages.All(lang => languages.Contains(lang));
        }
    }
}
