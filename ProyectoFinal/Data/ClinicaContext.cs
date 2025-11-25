using ProyectoFinal.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ProyectoFinal.Data
{
    // Heredamos de DbContext, que es la clase maestra de Entity Framework
    public class ClinicaContext : DbContext
    {
        // Este constructor es necesario para recibir la configuración (como la cadena de conexión)
        public ClinicaContext(DbContextOptions<ClinicaContext> options) : base(options)
        {
        }

        // Aquí definimos las tablas que tendrá nuestra BD
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Dentista> Dentistas { get; set; }
        public DbSet<Cita> Citas { get; set; }

        // Configuración adicional (opcional, pero recomendada para evitar conflictos con Citas)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Evitar borrado en cascada para no complicarnos la vida con errores de SQL
            // Si borras un paciente, sus citas no se borran automáticamente (más seguro por ahora)
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}