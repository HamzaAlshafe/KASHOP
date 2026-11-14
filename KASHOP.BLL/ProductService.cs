using KASHOP.DAL.DTO.Requests;
using KASHOP.DAL.Models;
using KASHOP.DAL.Repositories;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace KASHOP.BLL
{
    public class ProductService : IProductService
    {
        private readonly IFileService _fileservice;
        private readonly IGenericRepository<Product> _productrepo;

        public ProductService(IFileService fileService,IGenericRepository<Product> productrepo) {
            _fileservice = fileService;
            _productrepo = productrepo;
        }
        public async Task<bool> CreateAsync(ProductRequest request, CancellationToken cancellationToken = default)
        {
            var ImageName = await _fileservice.UploadAsync(request.MainImage, cancellationToken);
            if (ImageName == null) return false;

            var product = request.Adapt<Product>();
            product.MainImage = ImageName;

            try
            {
                await _productrepo.CreateAsync(product, cancellationToken);
            }
            catch
            {
                _fileservice.Delete(ImageName);
                throw;
            }
            return true;
        }

        public async Task<List<ProductResponse>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var products = await _productrepo.GetAsync(
                includes: [p=>p.Translations, p=>p.Category.Translations],
                cancellationToken: cancellationToken
                );

            return products.Adapt<List<ProductResponse>>();
        }
    }
}
