using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_17
{
    internal class AudioBook : Livro
    {
        public int Duracao { get; set; }
        public AudioBook (string nome ,string autor, int ano, int duracao) : base(nome,autor, ano)
        {
            Duracao = duracao;
        }
        public void Apresentar()
        {
            Console.WriteLine($"Nome do AudioBook: {Nome}\nAutor: {Autor}\nAno: {Ano}\nDuração: {Duracao} minutos");
        }
    }
}

