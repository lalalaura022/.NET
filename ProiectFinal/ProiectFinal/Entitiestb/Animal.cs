using ProiectFinal.Entitiestb;
using System.Collections;
using System.Collections.Generic;

namespace ProiectFinal.Entities
{
    public class Animal
    {
        public int Id { get; set; }
        public string Denumire { get; set; }

        public ICollection<Ingrijitor> Ingrijitori { get; set; }

        public ICollection<AnimalMedicament> AnimalMedicamente{ get; set; }
    }
}
