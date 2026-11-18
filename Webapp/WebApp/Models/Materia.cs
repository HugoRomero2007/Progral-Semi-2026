using System.ComponentModel.DataAnnotations;
namespace WebApp.Models
{
    public class Materia
    {
        [Key]
        public int IdMateria { get; set; }

        public int codigo { get; set; } 

        public string nombre { get; set; } = string.Empty;

        public int uv { get; set; }
    }
}