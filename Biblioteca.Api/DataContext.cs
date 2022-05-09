using Biblioteca.Api.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Biblioteca.Api.Controllers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Livro> Livros { get; set; }
    }
}
