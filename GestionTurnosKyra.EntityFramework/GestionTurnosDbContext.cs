using GestionTurnosKyra.Data.Models.GestionTurnos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTurnosKyra.EntityFramework
{
    public class GestionTurnosDbContext : DbContext
    {
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<Turno> Turno { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Cliente>().ToTable("Cliente", "Tno");
            modelBuilder.Entity<Servicio>().ToTable("Servicio", "Tno");
            modelBuilder.Entity<Turno>().ToTable("Turno", "Tno");

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=GestionTurnosKyra;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
