using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_18
{
    internal class CameraTraseira : Camera
    {
        public int ResolucaoAtual { get; set; }
        public CameraTraseira(int resolucaoMaxima, int resolucaoAtual) : base(resolucaoMaxima)
        {
            if (resolucaoAtual > resolucaoMaxima)
            {
                ResolucaoAtual = resolucaoMaxima;
            }
            else
            {
                ResolucaoAtual = resolucaoAtual;
            }
        }
    }
}
