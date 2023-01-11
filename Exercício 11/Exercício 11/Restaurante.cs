using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_11
{
    internal class Restaurante
    {
        private string Cidade { get; }
        private bool Delivery { get; }
        public int PedidosPendentes { get; set; }
        private int TempoDeEntregaEstimado { get; set; }

        public Restaurante(string cidade, bool delivery)
        {
            Cidade = cidade;
            Delivery = delivery;
            PedidosPendentes = 0;
            TempoDeEntregaEstimado = 0;
        }
        public void Entrega()
        {
            if (Delivery)
            {
                Console.Write($"Olá! Nosso restaurante fica localizado em {Cidade}. Qual a sua cidade?  : ");
                string cidade = Console.ReadLine();
                if (cidade.ToUpper() == Cidade.ToUpper())
                {
                    TempoDeEntregaEstimado = (10 + 2*PedidosPendentes);
                    Console.WriteLine($"Perfeito! Seu pedido está em andamento! " +
                        $"o tempo estimado de entrega é {TempoDeEntregaEstimado} minutos");
                    PedidosPendentes++;
                }
                else
                {
                    Console.WriteLine("infelizmente não realizamos entregas em outra cidade!");
                }
            }
            else
            {
                Console.WriteLine("Infelizmente nosso restaurante não realiza delivery," +
                    " venha nos fazer uma visita para experimentar nossos pratos ! estamos localizados" +
                    " na cidade de " + Cidade);
            }
        }
    }
}
