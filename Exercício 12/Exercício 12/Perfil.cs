using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_12
{
    internal class Perfil
    {
        public string Nome { get; set; }
        public string FotoDePerfil { get; private set; }
        public string Tema { get; private set; }
        public Perfil(string nome)
        {
            this.Nome = nome;
        }
        public void TrocaFotoPerfil()
        { bool verif;
            string url = "";
            do
            {
                Console.WriteLine("insira o URL da sua foto: ");
                url = Console.ReadLine();
                if (url.StartsWith("http") || url.StartsWith("https"))
                {
                    this.FotoDePerfil = url;
                    verif = true;
                }
                else
                {
                    Console.WriteLine("insira um URL válido (inicie com http ou https)");
                    verif = false;
                }
            } while (verif == false);
        }
        public void MudaTema()
        {
            string tema = "";
            bool verif;
            do
            {
                Console.WriteLine("Digite qual tema você deseja! (light ou dark) ");
                tema = Console.ReadLine();
                if (tema.ToLower() == "light" || tema.ToLower() == "dark")
                {
                    verif = true;
                    this.Tema = tema;
                }
                else
                {
                    verif = false;
                    Console.WriteLine("insira um tema existente!");
                }
            }
            while (verif == false);
        }
    }
}
