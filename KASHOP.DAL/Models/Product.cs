using System;
using System.Collections.Generic;
using System.Text;

namespace KASHOP.DAL.Models
{
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public double Rate { get; set; }
        public string MainImage { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<ProductTranslation> Translations { get; set; } = new();
    }
}
