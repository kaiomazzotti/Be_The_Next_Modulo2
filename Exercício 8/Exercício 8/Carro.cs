using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_8
{
    internal class Carro
    {   private decimal precoGasolina = 5.62M;
        private decimal precoAlcool = 4.16M;
        public string Cor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int CapacidadeDoTanque { get; set; }
        public string TipoDeCombustível { get; set; }
        public Carro(string cor, string marca, string modelo, int capacidadeDoTanque, string tipoDeCombustível)
        {
            Cor = cor;
            Marca = marca;
            if (modelo.ToLower() == "sedan" || modelo.ToLower() == "hatch")
            {
                Modelo = modelo.ToLower();
            }
            else
            {
                Console.WriteLine("modelo de carro não existe");
            }
            CapacidadeDoTanque = capacidadeDoTanque;
            if(tipoDeCombustível.ToLower() == "gasolina" || tipoDeCombustível.ToLower() == "álcool" || tipoDeCombustível.ToLower() == "flex")
            {
                TipoDeCombustível = tipoDeCombustível.ToLower();
            }
            else
            {
                Console.WriteLine("Tipo de combustível inválido");
            }
        }
        public int Abastecer()
        {
            int abastecimento = 0;
            Console.WriteLine("Vamos abastecer o seu carro!");
            Console.WriteLine("Quantos litros você deseja abastecer?");
            int.TryParse(Console.ReadLine(), out int litros);
            if (litros > CapacidadeDoTanque)
            {
                Console.WriteLine("Seu tanque é menor que a quantidade desejada");
            }
            else
            {
                abastecimento = litros;
                switch(TipoDeCombustível)
                {
                    case "gasolina":
                        Console.WriteLine($"Abastecimento concluído! o preço ficou: R${(precoGasolina * litros)}");
                        break;
                    case "álcool":
                        Console.WriteLine($"Abastecimento concluído! o preço ficou: R${(precoAlcool * litros)}");
                        break;
                    case "flex":
                        Console.WriteLine($"escolha (1) se deseja abastecer gasolina ou (2) se deseja abastecer álcool");
                        int.TryParse(Console.ReadLine(), out int escolha);
                        if (escolha == 1)
                        {
                            Console.WriteLine($"Abastecimento de gasolina concluído! o preço ficou: R${(precoGasolina * litros)}");
                        }
                        else if (escolha == 2)
                        {
                            Console.WriteLine($"Abastecimento de álcool concluído! o preço ficou: R${(precoAlcool * litros)}");
                        }
                        else
                        {
                            Console.WriteLine("você não escolheu uma opção válida");
                        }
                        break;
                }
            }
            return abastecimento;
        }
    }
}
