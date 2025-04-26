using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAdopcionMascotas.Models
{
    public class Adoption
    {
        public int Id { get; set; }

        [Required]
        public int PetId { get; set; }

        [Required]
        public int AdopterId { get; set; }

        public DateTime AdoptionDate { get; set; } = DateTime.Now;

        // Relaciones
        public Pet Pet { get; set; }
        public Adopter Adopter { get; set; }
    }
}
