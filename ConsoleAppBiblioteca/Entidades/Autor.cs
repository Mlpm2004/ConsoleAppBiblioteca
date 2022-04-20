using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBiblioteca.Entidades
{
    public class Autor
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public Livro Livros { get; set; }
        public Autor(string nome,string sobrenome,Livro livros)
        {
            Nome = nome;
            Sobrenome = sobrenome;  
            Livros = livros;

        } 
    }

}
