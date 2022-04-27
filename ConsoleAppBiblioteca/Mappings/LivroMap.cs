using ConsoleAppBiblioteca.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleAppBiblioteca.Mappings

{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            // Primary key
            builder.HasKey(l => l.Codigo);
            // Properties
            builder.Property(l => l.CodigoCategoria)
                .HasColumnType("int")
                .HasColumnName("CodigoCategoria");
            builder.Property(l => l.Codigo)
                .HasColumnType("int")
                .HasColumnName("Codigo");
            builder.Property(l => l.Titulo)
                .HasColumnType("varchar(255)")
                .HasColumnName("Titulo");
            builder.HasOne(l => l.Autor)
                .WithMany(l => l.Livros)
                .HasForeignKey(l => l.CodigoAutor);
            builder.HasOne(l => l.Categoria)
               .WithMany(l => l.Livros)
               .HasForeignKey(l => l.CodigoCategoria);





        }
    }
}
