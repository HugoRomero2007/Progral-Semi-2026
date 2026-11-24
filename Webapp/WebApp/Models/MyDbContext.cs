using Microsoft.EntityFrameworkCore;
using WebApp.Models; // Asegúrate de que coincida con el nombre real de tu proyecto

namespace WebApp.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Alumno> Alumnos { get; set; }

        public DbSet<Materia> Materias { get; set; }

        public DbSet<Docente> Docentes { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Alumno>().HasKey(a => a.IdAlumnos);
            modelBuilder.Entity<Materia>().HasKey(a => a.IdMateria);
            modelBuilder.Entity<Docente>().HasKey(a => a.IdDocente);
        }
    }
}