using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_18
{
    internal class Celular
    {   private int _contador = 0; 
        public int EspacoDisponivel { get; set; }
        public CameraTraseira CamTraseira { get; set; }
        public CameraFrontal CamFrontal { get; set; }
        public Celular(int espacoDisponivel, CameraFrontal camFrontal , CameraTraseira camTraseira)
        {
            EspacoDisponivel = espacoDisponivel;
            if (camFrontal.ResolucaoAtual > camTraseira.ResolucaoAtual)
            {
                Console.WriteLine("A câmera frontal não pode ter mais resolução que a traseira");
            }
            else
            {
                CamTraseira = camTraseira;
                CamFrontal = camFrontal;
            }
        }
        public void TirandoFotosCelularF()
        {
            if (_contador >= EspacoDisponivel)
            {
                Console.WriteLine("você não pode mais tirar fotos, o limite são" + EspacoDisponivel + "fotos");
            }
            else
            {
                CamFrontal.TirarFoto();
                Console.WriteLine("Você tirou foto com a camera Frontal!");
                _contador++;
            }
        }
        public void TirandoFotosCelularT()
        {
            if (_contador >= EspacoDisponivel)
            {
                Console.WriteLine("você não pode mais tirar fotos, o limite são" + EspacoDisponivel + "fotos");
            }
            else
            {
                CamTraseira.TirarFoto();
                Console.WriteLine("Você tirou foto com a camera traseira!");
                _contador++;
            }
        }
    }
}
