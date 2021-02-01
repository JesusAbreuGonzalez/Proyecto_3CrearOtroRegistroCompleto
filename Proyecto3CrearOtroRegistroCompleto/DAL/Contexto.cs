using Microsoft.EntityFrameworkCore;
using Proyecto3CrearOtroRegistroCompleto.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto3CrearOtroRegistroCompleto.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = GestionUsuarios.Db");
        }
    }
}
