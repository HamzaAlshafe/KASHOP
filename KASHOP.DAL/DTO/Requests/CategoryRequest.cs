using System;
using System.Collections.Generic;
using System.Text;

namespace KASHOP.DAL.DTO.Requests
{
    public class CategoryRequest
    {
        public List<CategoryTranslationRequest> Translations = new();
        public bool Status { get; set; }
    }
}
