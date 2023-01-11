//Crie uma classe Time que tenha como propriedade o nome do país, nome do esporte e a pontuação dele em um torneio.
//Sua pontuação pode ser acrescida por um método pontua que recebe como parâmetro "W" para vitória (+3 pontos),
//"L" para derrota(+0 pontos) e "D" para empate(+1 ponto).

using Exercício_9;
Time t1 = new Time("Brasil", "Futebol");
Console.WriteLine($"digite quantas partidas de {t1.Esporte} a seleção {t1.Pais} jogou no ano");
Random rd = new Random();
int partida;
char resultado;
int.TryParse(Console.ReadLine(), out int partidas);
Console.WriteLine();
for (int i = 0; i < partidas; i++)
{
    partida = rd.Next(1,4);
    if (partida == 1)
    {
        resultado = 'W';
        Console.WriteLine($"Você ganhou a {i+1}ª partida");
    }
    else if (partida == 2)
    {
        resultado = 'D';
        Console.WriteLine($"Você empatou a {i + 1}ª partida");
    }
    else
    {
        resultado = 'L';
        Console.WriteLine($"Você perdeu a {i + 1}ª partida");
    }
    t1.Pontuar(resultado);

}
Console.WriteLine($"\nA seleção {t1.Pais} no esporte {t1.Esporte} jogou {partidas} partidas no ano! e ficou com {t1.Pontuação} pontos");