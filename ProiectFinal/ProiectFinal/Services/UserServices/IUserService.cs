using ProiectFinal.Models.DTOs;
using System.Threading.Tasks;

namespace ProiectFinal.Services.UserServices
{
    public interface IUserService
    {
        Task<bool> RegisterUserAsync(RegisterUserDTO dto);
        Task<string> LoginUser(LoginUserDTO dto);
    }
}
