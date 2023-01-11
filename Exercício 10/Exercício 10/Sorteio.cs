using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_10
{
    static class Sorteio
    {
        public static int SorteiaPremio(int participantes)
        {
            Random random = new Random();
            int n;
            n = random.Next(1,participantes+1);
            Console.WriteLine($"O participante PREMIADO foi o de inscrição n° {n}");
            return n;
        }
    }
}
