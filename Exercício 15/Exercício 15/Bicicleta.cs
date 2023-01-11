using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_15
{
    internal class Bicicleta : Veiculo
    {
        public bool Criança { get; set; }
        public Bicicleta(int rodas, bool usaCombustivel, bool criança):base(rodas,usaCombustivel)
        {
            Criança = criança;
            if(criança == true)
            {
                if(Rodas < 3)
                {
                    Console.WriteLine("Por ser uma bicicleta infantil, é necessário que tenha mais de 2 rodas para estabilidade");
                }
            }
            else
            {
                if(Rodas < 2)
                {
                    Console.WriteLine("bicicleta não funciona sem ter ao menos 2 rodas");
                }
            }
            
        }
    }
}
