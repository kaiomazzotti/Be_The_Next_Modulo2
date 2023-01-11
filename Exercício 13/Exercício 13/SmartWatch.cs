using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_13
{
    internal class SmartWatch
    {
        public int Passos { get; private set; }
        public SmartWatch()
        {
            Passos = 0;
        }
        public void IncrementaPassos(int passosDados)
        {
            if (passosDados < 0)
            {
                passosDados *= -1;
            }
            Passos += passosDados;
        }
        public void ResetOnMidnight()
        {
            Passos = 0;
        }
    }
}
