using Microsoft.EntityFrameworkCore;
using ProiectFinal.Models;
using ProiectFinal.Models.Entities;
using ProiectFinal.Repositories;
//using ProiectFinal.Repositories.UserRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProiectFinal.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email.Equals(email));
        }
    }
}
