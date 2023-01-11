using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_17
{
    internal class Livro
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }

        public Livro(string nome, string autor, int ano)
        {
            Nome = nome;
            Autor = autor;
            Ano = ano;
        }
    }
}
