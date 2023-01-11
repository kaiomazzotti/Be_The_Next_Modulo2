using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_15
{
    internal class Carro : Veiculo
    {
        public string TipoCombustivel { get; set; }
        public Carro(int rodas , bool usaCombustivel , string tipoCombustivel) : base(rodas ,usaCombustivel)
        {
            if(Rodas < 4)
            {
                Console.WriteLine("seu carro não anda sem ter ao menos 4 rodas");
            }
            if (usaCombustivel == false)
            {
                Console.WriteLine("seu carro não funciona sem combustível");
                TipoCombustivel = "---";
            }
            else
            {
                if (tipoCombustivel.ToLower() == "gasolina" || tipoCombustivel.ToLower() == "álcool" || tipoCombustivel.ToLower() == "flex")
                {
                    TipoCombustivel = tipoCombustivel;
                }
                else
                {
                    Console.WriteLine("Tipo de combustível inválido");
                    TipoCombustivel = "---";
                }
            }
        }

    }
}
