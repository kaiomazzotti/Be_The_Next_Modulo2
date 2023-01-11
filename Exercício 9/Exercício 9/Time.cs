using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_9
{
    internal class Time
    {
        public string Pais { get; set; }
        public string Esporte { get; set; }
        public int Pontuação { get; set; }

        public Time(string pais, string esporte)
        {
            Pais = pais;
            Esporte = esporte;
            Pontuação = 0;
        }   
        public void Pontuar(char resultado)
        {
            if(resultado == 'W')
            {
                Pontuação += 3;
            }
            else if(resultado == 'D')
            {
                Pontuação ++;
            }
            else if(resultado == 'L')
            {
                Pontuação += 0;
            }
        }
    }
}
