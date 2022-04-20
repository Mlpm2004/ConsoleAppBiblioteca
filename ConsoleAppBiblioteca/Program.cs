
using ConsoleAppBiblioteca.Context;
using ConsoleAppBiblioteca.Entidades;
using Microsoft.EntityFrameworkCore;
using (var db = new DataContext())
{
    //somene para efeito de testes
    db.Database.EnsureCreated();
    if (db.Autor.Any())
    {
        db.Database.ExecuteSqlRaw("DELETE FROM \"Autor\"");
    }
    db.Autor.Add(new Autor("Domain-Driven Design: Tackling Complexity in the Heart of Software", "Eric Evans"));
    db.SaveChanges();
}