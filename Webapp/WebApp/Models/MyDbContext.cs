using Microsoft.EntityFrameworkCore;
using WebApp.Models; // Asegúrate de que coincida con el nombre real de tu proyecto

namespace WebApp.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Alumno> Alumnos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Alumno>().HasKey(a => a.IdAlumnos);
        }
    }
}