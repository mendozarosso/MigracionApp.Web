using Microsoft.EntityFrameworkCore;
using MigracionApp.Web.Models;

namespace MigracionApp.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Detenido> Detenidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Detenido>()
                .HasKey(d => d.Id);

            modelBuilder.Entity<Detenido>()
                .Property(d => d.NombreCompleto)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Detenido>()
                .Property(d => d.NumeroPasaporte)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}