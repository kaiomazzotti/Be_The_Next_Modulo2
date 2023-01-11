using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_16
{
    public class Filme : Programa
    {
        public int Duracao { get; set; }
        public Filme(string nome, string genero , int duracao) : base (nome, genero)
        {
            this.Duracao = duracao;
        }

        public void Apresentar()
        {
            Console.WriteLine($"O filme {Nome} é de gênero {Genero} e tem {Duracao} minutos de duração");
        }
    }
}
