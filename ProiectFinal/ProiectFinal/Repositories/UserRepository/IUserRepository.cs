using ProiectFinal.Models.Entities;
using ProiectFinal.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProiectFinal.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserByEmail(string email);
    }
}
