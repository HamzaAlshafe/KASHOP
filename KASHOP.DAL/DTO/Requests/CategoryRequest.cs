using System;
using System.Collections.Generic;
using System.Text;

namespace KASHOP.DAL.DTO.Requests
{
    public class CategoryRequest
    {
        public string Name { get; set; } = null!;
        public bool Status { get; set; }
    }
}
