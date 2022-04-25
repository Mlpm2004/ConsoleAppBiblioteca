
using ConsoleAppBiblioteca.Context;
using ConsoleAppBiblioteca.Entidades;
using Microsoft.EntityFrameworkCore;
using (var db = new DataContext())
{
    //somene para efeito de testes
    db.Database.EnsureCreated();
    if (db.Autores.Any())
    {
        db.Database.ExecuteSqlRaw("DELETE FROM \"Autores\"");
    }
    if (db.Livros.Any())
    {
        db.Database.ExecuteSqlRaw("DELETE FROM \"Livros\"");
    }
    if (db.Categorias.Any())
    {
        db.Database.ExecuteSqlRaw("DELETE FROM \"Categorias\"");
    }
    db.SaveChanges();
}
