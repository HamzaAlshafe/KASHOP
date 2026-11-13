using System;

namespace KASHOP.DAL.DTO.Requests;

public class ProductTranslationRequest
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Language { get; set; } = null!;
}
