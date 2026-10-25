using System;
using System.Collections.Generic;
using System.Text;

namespace KASHOP.DAL.Models
{
    public class Category
    {
        public int Id { get; set; }

        public bool Status { get; set; }

        public List<CategoryTranslation> Translations { get; set; } = new();
    }
}
