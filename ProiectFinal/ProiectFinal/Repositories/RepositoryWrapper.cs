﻿using ProiectFinal.Models;
using System.Threading.Tasks;

namespace ProiectFinal.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly AppDbContext _context;

        private IUserRepository _user;
        public RepositoryWrapper(AppDbContext context)
        {
            _context = context;
        }
        public IUserRepository User
        {
            get
            {
                if (_user == null)
                    _user = new UserRepository(_context);
                return _user;
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
