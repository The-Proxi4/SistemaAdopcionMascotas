using System.ComponentModel.DataAnnotations;

namespace SistemaAdopcionMascotas.Models
{
    public class Adopter
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";

        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";

        // Relación: un adoptante puede adoptar varias mascotas
        public List<Adoption> Adoptions { get; set; } = new List<Adoption>();
    }
}
