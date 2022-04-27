using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBiblioteca.Entidades
{
    public class Autor
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public ICollection<Livro> Livros { get; private set; }
        public Autor(int codigo,string nome, string sobrenome)
        {
            Codigo = codigo;
            Nome = nome;
            Sobrenome = sobrenome;
        }
    }

}
