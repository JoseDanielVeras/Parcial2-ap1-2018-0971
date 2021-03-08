using Microsoft.EntityFrameworkCore;
using Parcial2_ap1_2018_0971.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_ap1_2018_0971.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Proyectos> Proyectos { get; set; }
        public DbSet<ProyectosDetalle> ProyectosDetalle { get; set; }
        public DbSet<TareasTipos> TareasTipos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA/GestionProyectos.Db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TareasTipos>().HasData(
               new TareasTipos() { TipoId = 1, Descripcion = "Análisis", Requerimiento = "Analizar la opción de clientes", Tiempo = 120 },
               new TareasTipos() { TipoId = 2, Descripcion = "Diseño", Requerimiento = "Hacer un diseño excelente", Tiempo = 60 },
               new TareasTipos() { TipoId = 3, Descripcion = "Programación", Requerimiento = "Programar todo el registro", Tiempo = 240 },
               new TareasTipos() { TipoId = 4, Descripcion = "Prueba", Requerimiento = "Probar con mucho cuidado", Tiempo = 30 }
           );
        }
    }
}
