using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    [Table("alumnos")]
    public class Alumno
    {
        [Key]
        public int IdAlumnos { get; set; }

        public string codigo { get; set; } = string.Empty;

        public string nombre { get; set; } = string.Empty;

        public string direccion { get; set; } = string.Empty;

        public string? telefono { get; set; }

        public string? email { get; set; }
    }
}