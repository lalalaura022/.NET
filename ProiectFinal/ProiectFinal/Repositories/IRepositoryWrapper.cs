using System.Threading.Tasks;

namespace ProiectFinal.Repositories
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get;  }
        Task SaveAsync();
    }
}
