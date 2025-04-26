using Microsoft.EntityFrameworkCore;
using SistemaAdopcionMascotas.Models;

namespace SistemaAdopcionMascotas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Adopter> Adopters { get; set; }
        public DbSet<Adoption> Adoptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Restricción: Pet solo puede tener una Adoption
            modelBuilder.Entity<Adoption>()
                .HasOne(a => a.Pet)
                .WithOne(p => p.Adoption)
                .HasForeignKey<Adoption>(a => a.PetId);

            modelBuilder.Entity<Adoption>()
                .HasOne(a => a.Adopter)
                .WithMany(ad => ad.Adoptions)
                .HasForeignKey(a => a.AdopterId);
        }
    }
}
