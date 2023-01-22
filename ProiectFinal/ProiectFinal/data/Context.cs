using Microsoft.EntityFrameworkCore;
using ProiectFinal.Entities;
using ProiectFinal.Entitiestb;

namespace ProiectFinal.data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Ingrijitor> Inrijitori { get; set; }

        public DbSet<AnimalMedicament> AnimalMedicamente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .HasMany(a => a.Ingrijitori)
                .WithOne(i => i.Animal);


            modelBuilder.Entity<Ingrijitor>()
                .HasOne(i => i.Address)
                .WithOne(adr => adr.Ingrijitor);

            modelBuilder.Entity<AnimalMedicament>().HasKey(am => new { am.MedicamentId, am.AnimalId });
            
            modelBuilder.Entity<AnimalMedicament>() 
                .HasOne(am => am.Animal)
                .WithMany(a => a.AnimalMedicamente)
                .HasForeignKey(am => am.AnimalId);

            modelBuilder.Entity<AnimalMedicament>()
                .HasOne(am => am.Medicament)
                .WithMany(a => a.AnimalMedicamente)
                .HasForeignKey(am => am.MedicamentId);

            base.OnModelCreating(modelBuilder);
        }


    }
}
