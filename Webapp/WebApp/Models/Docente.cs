using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Docente
    {
        [Key]
        public int IdDocente { get; set; }

        public string codigo { get; set; } = string.Empty;

        public string nombre { get; set; } = string.Empty;

        public string direccion { get; set; } = string.Empty;

        public string? telefono { get; set; }

        public string? email { get; set; }

        public string? escalafon { get; set; }

    }
}
