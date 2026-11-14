using KASHOP.DAL.DTO.Requests;
using KASHOP.DAL.Models;
using Mapster;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KASHOP.BLL.Settings
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManger;
        public AuthService (UserManager<ApplicationUser> userManger)
        {
            _userManger = userManger;
        }
        public async Task<(bool Success, List<string> Errors)> RegisterAsync(RegisterRequest request, CancellationToken cancellationToken = default)
        {
            var user = request.Adapt<ApplicationUser>();
            var result = await _userManger.CreateAsync(user,request.Password);

            if (!result.Succeeded)
            {
                return (false, result.Errors.Select(e => e.Description).ToList());
            }
            return (true, []);
        }
    }
}
