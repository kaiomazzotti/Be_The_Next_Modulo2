using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    internal class CNH
    {
        private string _tipo;
        public string Pais { get; set; }
        public int Idade { get; private set; }  
        public string TipoCarteira { get; private set; }

        public CNH(string pais)
        {
            Pais = pais;
        }

        public void RecebeIdade(int idade)
        {
            switch (this.Pais)
            {
                case "US":
                case "CA":
                    if (idade > 16)
                    {
                        this.Idade = idade;
                        Console.WriteLine("Aceito para fabricar CNH");
                    }
                    else
                        Console.WriteLine("Precisa ter mais de 16 anos");
                    break;
                case "CH":
                case "RU":
                    if (idade > 21)
                    {
                        this.Idade = idade;
                        Console.WriteLine("Aceito para fabricar CNH");
                    }
                    else
                        Console.WriteLine("Precisa ter mais de 21 anos");
                    break;
                case "BR":
                    if (idade > 18)
                    {
                        this.Idade = idade;
                        Console.WriteLine("Aceito para fabricar CNH");
                        Console.WriteLine("informe a categoria da sua carteira: (A, B, C, D, E, AB, AC, AD ou AE)");
                        _tipo = Console.ReadLine().ToUpper();
                        if (_tipo == "A" || _tipo == "B" || _tipo == "C" || _tipo == "D" || _tipo == "E" || _tipo == "AB" || _tipo == "AC" || _tipo == "AD" || _tipo == "AE")
                        {
                            TipoCarteira = _tipo;
                        }
                        else
                            Console.WriteLine("Você não inseriu uma categoria válida");
                    }
                    else
                        Console.WriteLine("Precisa ter mais de 18 anos");
                    break;
                    default:
                    if (idade > 18)
                    {
                        this.Idade = idade;
                        Console.WriteLine("Aceito para fabricar CNH");
                    }
                    else
                        Console.WriteLine("Precisa ter mais de 18 anos");
                    break;
            }
        }

    }
}
