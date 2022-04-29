
using ConsoleAppBiblioteca.Context;
using ConsoleAppBiblioteca.Entidades;
using Microsoft.EntityFrameworkCore;
var dml = new DML();
var dql = new DQL();
using (var db = new DataContext())
{
    //somene para efeito de testes
    /*
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
    db.Database.EnsureCreated();
    */
}
    var ObterLivroPorCodigo = dql.ObterLivroPorCodigo(12);
    Console.WriteLine($"Consulta Por Código");
    Console.WriteLine($"ID : {ObterLivroPorCodigo.Id} | Titulo : {ObterLivroPorCodigo.Titulo} | Autor : {ObterLivroPorCodigo.Autor.Nome} | Categoria : {ObterLivroPorCodigo.Categoria.Nome} ");
    var ObterLivrosPorCategoria = dql.ObterLivroPorCategoria(1);
    Console.WriteLine("Obter Livros Por Categoria");
    foreach(var item in ObterLivrosPorCategoria)
        Console.WriteLine($"ID : {item.Id} | Titulo : {item.Titulo} | Autor : {item.Autor.Nome} | Categoria : {item.Categoria.Nome} ");
    var ObterLivrosPorAutor = dql.ObterLivrosPorAutor(1);
    Console.WriteLine("Obter Livros Por Autor");
    foreach (var item in ObterLivrosPorAutor)
        Console.WriteLine($"ID : {item.Id} | Titulo : {item.Titulo} | Autor : {item.Autor.Nome} | Categoria : {item.Categoria.Nome} ");





