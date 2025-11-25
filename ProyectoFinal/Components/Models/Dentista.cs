using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Dentista
    {
        [Key]
        public int IdDentista { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; } = string.Empty; 

        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string Apellido { get; set; } = string.Empty; 

        [Required(ErrorMessage = "La especialidad es obligatoria")]
        public string Especialidad { get; set; } = string.Empty; 

        [Required]
        [EmailAddress(ErrorMessage = "Formato de correo inválido")]
        public string EmailProfesional { get; set; } = string.Empty; 

        [Required]
        public string Password { get; set; } = string.Empty; 
    }
}