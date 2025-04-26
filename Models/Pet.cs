using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAdopcionMascotas.Models
{
    public class Pet
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";

        [Required]
        [Range(0, 30, ErrorMessage = "Edad debe ser entre 0 y 30 años.")]
        public int Age { get; set; }

        [Required]
        public string Type { get; set; } = "";

        [Required]
        public bool IsAdopted { get; set; } = false;

        // Relación: una mascota puede tener una adopción
        public Adoption? Adoption { get; set; }
    }
}
