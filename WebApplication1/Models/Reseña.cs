using System.ComponentModel.DataAnnotations;

namespace TuProyecto.Models
{
    public class Reseña
    {
        [Key]  
        public int Id { get; set; }

        [Required(ErrorMessage = "El comentario es obligatorio")]
        public string Comentario { get; set; } = string.Empty;

        [Range(1, 5, ErrorMessage = "Selecciona una calificación entre 1 y 5")]
        public int Calificacion { get; set; }
    }
}