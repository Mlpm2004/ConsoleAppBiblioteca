using ConsoleAppBiblioteca.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleAppBiblioteca.Mappings
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            // Primary key
            builder.HasKey(a => a.Codigo);
            // Properties
            builder.Property(a => a.Codigo)
                .HasColumnType("int")
                .HasColumnName("Codigo");
            builder.Property(a => a.Nome)
                .HasColumnType("varchar(100)")
                .HasColumnName("Nome"); ;
        }
    }
}
