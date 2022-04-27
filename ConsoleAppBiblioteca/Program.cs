
using ConsoleAppBiblioteca.Context;
using ConsoleAppBiblioteca.Entidades;
using Microsoft.EntityFrameworkCore;
var dml = new DML();
using (var db = new DataContext())
{
    //somene para efeito de testes
    db.Database.EnsureCreated();
    if (db.Livros.Any())        db.Database.ExecuteSqlRaw("DELETE FROM \"Livros\"");
    if (db.Autores.Any())       db.Database.ExecuteSqlRaw("DELETE FROM \"Autores\"");
    if (db.Categorias.Any())    db.Database.ExecuteSqlRaw("DELETE FROM \"Categorias\"");
    var autores = dml.CriarAutores();
    db.Autores.AddRange(autores);
    db.SaveChanges();
    var categorias = dml.CriarCategorias();
    db.Categorias.AddRange(categorias);
    db.SaveChanges();
    var livros = dml.CriarLivros(); 
    db.Livros.AddRange(livros);
    db.SaveChanges();
    Livro livro = livros.FirstOrDefault(l => l.Codigo == 10);
    if (livro != null)
    {
        dml.EditarLivros(livro);
    }
    db.SaveChanges();
    var livror= dml.ExcluirLivros(11,livros);
    db.Remove(livror);
    db.SaveChanges();   






}
