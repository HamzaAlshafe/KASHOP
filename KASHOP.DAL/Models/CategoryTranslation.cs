using System;
using System.Collections.Generic;
using System.Text;

namespace KASHOP.DAL.Models
{
    public class CategoryTranslation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public int CategoryId { get; set; }
        public Category Cagtegory { get; set; }
    }
}
