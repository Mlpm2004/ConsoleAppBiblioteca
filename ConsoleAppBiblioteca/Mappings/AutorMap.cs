using ConsoleAppBiblioteca.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ConsoleAppBiblioteca.Mappings
{
    public class AutorMap : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {

            // Primary key
            builder.HasKey(a => a.Codigo);
            // Properties
            builder.Property(a => a.Codigo)
                .HasColumnType("int")
                .HasColumnName("Codigo");
            builder.Property(a => a.Nome)
                .HasColumnType("varchar(150)")
                .HasColumnName("Nome");
            builder.Property(a => a.Sobrenome)
                .HasColumnType("varchar(150)")
                .HasColumnName("Sobrenome");
            
        }


    }
}
