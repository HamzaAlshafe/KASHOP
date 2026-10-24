using System;
using System.Collections.Generic;
using System.Text;

namespace KASHOP.DAL.DTO.Responses
{
    public class CategoryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Status { get; set; }
    }
}
