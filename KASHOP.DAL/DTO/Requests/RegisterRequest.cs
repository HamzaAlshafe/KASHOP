using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KASHOP.DAL.DTO.Requests
{
    public class RegisterRequest
    {
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Password { get; set; } = null!;
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = null!;
    }
}
