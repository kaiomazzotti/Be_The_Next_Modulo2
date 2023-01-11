//Faça uma classe SmartWatch com a contagem dos passos diários de uma pessoa (pedômetro). Garanta utilizando
//acessors (get/set) que os passos apenas podem ser incrementados e um método resetOnMidnight() 
//que reseta os passos para 0.

using Exercício_13;

SmartWatch sm1 = new SmartWatch();
sm1.IncrementaPassos(40);
sm1.IncrementaPassos(-20);
sm1.IncrementaPassos(2);
Console.WriteLine($"Passos dados: {sm1.Passos}");
sm1.ResetOnMidnight();
sm1.IncrementaPassos(4);
Console.WriteLine($"Passos dados: {sm1.Passos}");