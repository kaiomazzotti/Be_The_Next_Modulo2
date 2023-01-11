using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_17
{
    internal class Ebook : Livro
    {
        public int NPaginas { get; set; }
        public int NCapitulos { get; set; }
        public Ebook(string nome, string autor, int ano, int nPaginas , int nCapitulos) : base(nome, autor, ano)
        {
            this.NPaginas = nPaginas;
            this.NCapitulos = nCapitulos;

        }
        public void Apresentar()
        {
            Console.WriteLine($"Nome do EBook: {Nome} \nAutor: {Autor}  \nAno: {Ano} \nCapítulos: {NCapitulos} \n Páginas : {NPaginas}");
        }
    }
}
