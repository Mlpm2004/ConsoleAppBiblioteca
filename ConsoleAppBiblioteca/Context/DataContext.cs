using ConsoleAppBiblioteca.Entidades;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppBiblioteca.Context
{
    public class DataContext : DbContext
    {
        //public DataContext(DbContextOptions options) : base(options) { }
        public DataContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost;Port=5432;Database=Biblioteca;User Id=postgres;Password=123456;"
            );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Autor> Autores { get; set; }

        
    }
}
