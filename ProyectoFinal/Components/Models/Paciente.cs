using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models // Asegúrate de que este namespace coincida con el nombre de tu proyecto
{
    public class Paciente
    {
        [Key] // Esto le dice a la BD que esta es la llave primaria
        public int IdPaciente { get; set; } 

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string Apellido { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;
    }
}