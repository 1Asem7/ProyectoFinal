using ProyectoFinal.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal.Models
{
    public class Cita
    {
        [Key]
        public int IdCita { get; set; }

        // --- Relación con Paciente ---
        [Required]
        public int IdPaciente { get; set; }

        [ForeignKey("IdPaciente")]
        public virtual Paciente? Paciente { get; set; } // <--- Agregamos el ?

        // --- Relación con Dentista ---
        [Required]
        public int IdDentista { get; set; }

        [ForeignKey("IdDentista")]
        public virtual Dentista? Dentista { get; set; } // <--- Agregamos el ?

        // --- Datos de la Cita ---
        [Required(ErrorMessage = "Debes seleccionar una fecha y hora")]
        public DateTime FechaHora { get; set; }

        [Required(ErrorMessage = "El motivo es obligatorio")]
        public string MotivoConsulta { get; set; } = string.Empty; // <--- Inicializamos vacío

        public string Estado { get; set; } = "Programada";

        public string? NotasDentista { get; set; }
    }
}