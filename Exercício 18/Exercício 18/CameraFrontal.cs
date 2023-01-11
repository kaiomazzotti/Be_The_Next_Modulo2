using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_18
{
    internal class CameraFrontal : Camera
    {
        public int ResolucaoAtual { get; set; }
        public CameraFrontal(int resolucaoMaxima, int resolucaoAtual) : base(resolucaoMaxima)
        {
            if(resolucaoAtual > resolucaoMaxima)
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
