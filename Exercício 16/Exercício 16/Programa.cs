using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_16
{
    public class Programa
    {
        public string Nome { get; set; }
        public string Genero { get; set; }
        public Programa(string nome, string genero)
        {
            this.Nome = nome;
            if(genero.ToLower() == "ação" || genero.ToLower() == "comédia" 
                || genero.ToLower() == "suspense" || genero.ToLower() == "drama" 
                || genero.ToLower() == "terror")
            {
                this.Genero = genero;
            }
            else 
            {
                Console.WriteLine("Não é um gênero válido");
                this.Genero = "-sem gênero-";
            }
        }
    }
}
