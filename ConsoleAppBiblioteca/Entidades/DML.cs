using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBiblioteca.Entidades
{
    public class DML
    {
        public List<Autor> CriarAutores()
        {
            var autores = new List<Autor>();
            autores.Add(new Autor(1,"EU","TU"));
            autores.Add(new Autor(2, "Ele", "nós"));
            autores.Add(new Autor(3, "vós", "eles"));
            return autores;

        }
        public List<Categoria> CriarCategorias()
        {
            var categorias = new List<Categoria>();
            categorias.Add(new Categoria(1,"Terror"));
            categorias.Add(new Categoria(2, "Ação"));
            categorias.Add(new Categoria(3, "Aventura"));
            return categorias;

        }
        public List<Livro> CriarLivros()
        {
            var livros= new List<Livro>();
            livros.Add(new Livro("Titulo1", 1, 1));
            livros.Add(new Livro("Titulo2", 2, 2));
            livros.Add(new Livro("Titulo3", 3, 3));
            return livros;
        }
        public Livro EditarLivros(Livro livro)
        {
            livro.Titulo = "Titulo4";
            return livro;
        }

        public Livro ExcluirLivros(int codigo, List<Livro> livros)
        {
            return livros.FirstOrDefault(p => p.Codigo == codigo);
        }
    }
}
