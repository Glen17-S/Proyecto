using Microsoft.EntityFrameworkCore;
using Sistema.Datos.Mapping.Almacen;
using Sistema.Entidades.Almacen;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Datos
{
    public class DbContextSistema : DbContext
    {
        //Para exponer la coleccion de todas las categorias
        public DbSet<Categoria> Categorias { get; set; }

        //Contructor de conexion
        public DbContextSistema(DbContextOptions<DbContextSistema> options) : base (options)
        {

        }
        
        //Metodo
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMap());
        }
    }
}
