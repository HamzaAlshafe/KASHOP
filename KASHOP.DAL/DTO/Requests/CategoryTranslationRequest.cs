using System;
using System.Collections.Generic;
using System.Text;

namespace KASHOP.DAL.DTO.Requests
{
    public class CategoryTranslationRequest
    {
        public string Name { get; set; } = null!;
        public string Language { get; set; } = null!;
    }
}
