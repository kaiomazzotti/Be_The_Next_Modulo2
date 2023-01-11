using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_18
{
    internal class Camera
    {
        public int ResolucaoMaxima { get; set; }
        public int FotosTiradas { get; set; }
        public Camera(int resolucaoMaxima)
        {
            ResolucaoMaxima = resolucaoMaxima;
            FotosTiradas = 0;
        }

        public  void TirarFoto()
        {
            FotosTiradas++;
        }
    }
}
