using ProiectFinal.Models.Entities;
using ProiectFinal.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectFinal.Repositories
{
    public interface ISessionTokenRepository : IGenericRepository<SessionToken>
    {
        Task<SessionToken> GetByJTI(string jti);
    }
}
