using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_16
{
    internal class Seriado : Programa
    {
        public int NumeroEpisodios { get; set; }
        public int AnoLancamento { get; set; }
        public int AnoDeFim { get; set; }
        public Seriado(string nome, string genero,int numeroEpisodios, int anoLancamento, int anoDeFim) : base( nome, genero)
        {
            if (numeroEpisodios > 1)
            {
                NumeroEpisodios = numeroEpisodios;
            }
            AnoLancamento = anoLancamento;
            AnoDeFim = anoDeFim;
        }

        public void Apresentar()
        {
            Console.WriteLine($"A série {Nome} de gênero {Genero} tem {NumeroEpisodios} episódios , seu ano de lançamento foi {AnoLancamento} e o ano de encerramento {AnoDeFim} ");
        }
    }
}
