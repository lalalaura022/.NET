using Microsoft.AspNetCore.Identity;
using ProiectFinal.Models.Constants;
using ProiectFinal.Models.DTOs;
using ProiectFinal.Models.Entities;
using System.Threading.Tasks;

namespace ProiectFinal.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;

        public UserService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task<bool> RegisterUserAsync(RegisterUserDTO dto)
        {
            var registerUser = new User();

            registerUser.Email = dto.email;
            registerUser.FirstName = dto.FirstName;
            registerUser.LastName = dto.LastName;

            var result = await _userManager.CreateAsync(registerUser, dto.password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(registerUser, UserRoleType.Admin);

                return true;
            }
            return false;
        }

        public async Task<string> LoginUser(LoginUserDTO dto)
        {
            return "";
        }
    }
}
