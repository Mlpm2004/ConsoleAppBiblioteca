using ConsoleAppBiblioteca.Context;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppBiblioteca.Entidades
{
    public class DQL
    {
        
        public List<Livro> ObterTodosLivros()
        {
            using (var db = new DataContext())
            {
                return db.Livros.Include(x=> x.Categoria).Include(x => x.Autor).ToList();
            }   
                
            
        }
        public Livro ObterLivroPorCodigo(int codigo)
        {
            using (var db = new DataContext())
            {
                return db.Livros.Include(x => x.Categoria).Include(x => x.Autor).Single(x => x.Codigo == codigo); 
            }
        }
        public List<Livro> ObterLivroPorCategoria(int codigoCategoria)
        {
            using (var db = new DataContext())
            {
                return db.Livros.Include(x => x.Categoria).Include(x => x.Autor).Where(x => x.CodigoCategoria == codigoCategoria).ToList();
            }
         }
        public List<Livro> ObterLivrosPorAutor(int codigoAutor)
        {
            using (var db = new DataContext())
            {
                return db.Livros.Include(x => x.Categoria).Include(x => x.Autor).Where(x => x.CodigoAutor == codigoAutor).ToList();
            }
        }


    }
}
