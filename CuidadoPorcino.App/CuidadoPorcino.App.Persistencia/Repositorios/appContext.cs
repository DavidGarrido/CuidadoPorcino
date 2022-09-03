using System;
using Microsoft.EntityFrameworkCore;
using CuidadoPorcino.App.Dominio;

namespace CuidadoPorcino.App.Persistencia
{
    public class appContext : DbContext
    {
        public DbSet<Cerdos> Cerdos { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Historia> Historia { get; set; }
        public DbSet<Visita> Visita { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)// configuracion de la base de datos 

            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=CuidadoPorcino");

            }
        }
    }
}