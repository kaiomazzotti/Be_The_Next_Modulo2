using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_14
{
    internal class AlbumDeFigurinhas
    {
        public int[] QuantidadeFigurinhasAlbum { get; set; }
        public int[] FigurinhasColadas { get; private set; }
        public AlbumDeFigurinhas(int quantidadeFigurinhas)
        {

            QuantidadeFigurinhasAlbum = new int[quantidadeFigurinhas];
            for (int i = 0; i < quantidadeFigurinhas; i++)
            {
                QuantidadeFigurinhasAlbum[i] = i + 1; 
            }
            FigurinhasColadas = new int[quantidadeFigurinhas];
        }

        public void ColarFigurinhas(int figurinha)
        {
            if (QuantidadeFigurinhasAlbum.Length < figurinha )
            {
                Console.WriteLine("Numero da figurinha não existe nesse álbum");
            }
            else if (QuantidadeFigurinhasAlbum[figurinha - 1] == FigurinhasColadas[figurinha - 1])
            {
                Console.WriteLine("Figurinha já existe no album");
            }
            else
            {
                FigurinhasColadas[figurinha - 1 ] = QuantidadeFigurinhasAlbum[figurinha - 1];
                Console.WriteLine($"Figurinha {figurinha} colada no album!");
            }
        }
        public void MostrarAlbum()
        {
            Console.WriteLine($"\n\nO Album Contém {QuantidadeFigurinhasAlbum.Length} figurinhas!\n" +
                $"Os locais [0] indicam figurinhas que ainda não foram coladas\n");
            int j = 1;
            foreach(int i in FigurinhasColadas)
            {
                if (j == 10)
                {
                    Console.Write($"[{i}]\t\n");
                    j = 1;
                }
                else
                {
                    Console.Write($"[{i}]\t");
                    j++;
                }
            }
        }
    }
}
