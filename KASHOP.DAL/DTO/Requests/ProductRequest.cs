using Microsoft.AspNetCore.Http;
using System;

namespace KASHOP.DAL.DTO.Requests;

public class ProductRequest
{
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public decimal Discount { get; set; }
    public IFormFile MainImage { get; set; }
    public int CategoryId { get; set; }
    public List<ProductTranslationRequest> Translations { get; set; } = new();
}
