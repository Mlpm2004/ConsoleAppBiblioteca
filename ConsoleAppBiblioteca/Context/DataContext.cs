using ConsoleAppBiblioteca.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppBiblioteca.Context
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost;Port=5432;Pooling=true;Database=Biblioteca;User Id=postgres;Password=mlpm2004"
            );
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Autor> Autor { get; set; }
    }
}
