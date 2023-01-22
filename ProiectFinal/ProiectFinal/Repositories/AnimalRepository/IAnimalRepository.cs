using ProiectFinal.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProiectFinal.Repositories.AnimalRepository
{
    public interface IAnimalRepository : IGenericRepository<Animal>
    {
        Task<Animal> GetByDenumire(string Denumire);
    }
}
