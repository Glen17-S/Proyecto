using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Entidades.Almacen;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Datos.Mapping.Almacen
{
    // los : es heredar del EntityFramework del tipo categoria
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            //Para mapear la tabla Categoria con la llave primaria
            builder.ToTable("categoria")
                 .HasKey(c => c.idCategoria);

            builder.Property(c => c.Nombre)
                .HasMaxLength(50);

            builder.Property(c => c.Descripcion)
                .HasMaxLength(256);
        }
    }
}
