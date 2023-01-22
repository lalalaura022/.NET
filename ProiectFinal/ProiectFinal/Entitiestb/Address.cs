namespace ProiectFinal.Entitiestb
{
    public class Address
    {
        public int Id { get; set; }
        public int IngrijitorId { get; set; }
        public string Oras { get; set; }
        public string Strada { get; set; }
        public int Numar { get; set; }

        public Ingrijitor Ingrijitor { get; set; }
    }
}
