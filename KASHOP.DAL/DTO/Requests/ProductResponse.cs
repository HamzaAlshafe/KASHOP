using KASHOP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KASHOP.DAL.DTO.Requests
{
    public class ProductResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public double Rate { get; set; }
        public string MainImageUrl { get; set; }
        public string CategoryName { get; set; }
    }
}
