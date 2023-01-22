using ProiectFinal.data;
using ProiectFinal.Entities;
using ProiectFinal.Repositories.GenericRepository;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectFinal.Repositories.AnimalRepository
{
    public class AnimalRepository : GenericRepository<Animal>, IAnimalRepository
    {
        public AnimalRepository(Context context) : base(context) { }

        public async Task<Animal> GetByDenumire(string Denumire)
        {
            return await _context.Animals.Where(a => a.Denumire.Equals(Denumire))
        }
    }
}
