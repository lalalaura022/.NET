using ProiectFinal.Entities;

namespace ProiectFinal.Entitiestb
{
    public class Ingrijitor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AnAngajare { get; set; }

        public int AnimalId { get; set; }
        public Animal Animal { get; set; }

        public Address Address { get; set; }
    }
}
