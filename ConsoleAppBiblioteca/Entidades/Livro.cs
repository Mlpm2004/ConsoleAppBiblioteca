using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBiblioteca.Entidades
{
    public class Livro
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public int CodigoCategoria { get; set; }
        public int CodigoAutor { get; set; }
        public string Titulo { get; set; }
        public int AnoPublicacao { get; set; }
        public Categoria Categoria { get; private set; }
        public Autor Autor { get; private set; }
    }
}
