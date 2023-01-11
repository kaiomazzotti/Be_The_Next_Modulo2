using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_15
{
    internal class Veiculo
    {
        public int Rodas { get; set; }
        public bool UsaCombustível { get; set; }
        public Veiculo(int rodas, bool usaCombustível)
        {
            if (rodas >= 1)
            {
                Rodas = rodas;
            }
            UsaCombustível = usaCombustível;
        }
    }

}
