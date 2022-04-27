using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBiblioteca.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public ICollection<Livro> Livros { get; private set; }
        public Categoria(string nome)
        {
            Nome = nome;
        }

        public Categoria(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
    }
}
