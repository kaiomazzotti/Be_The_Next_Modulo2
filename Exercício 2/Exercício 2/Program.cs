/*Construa uma classe CNH que tenha como propriedades país e idade que,
 por padrão, deve ser maior ou igual a 18,

 16 se país for igual a US ou CA e
 21 se páis corresponder a CH ou RU.

 Se o país for BR deve também ser informada a
 categoria da carteira (A, B, C, D, E, AB, AC, AD ou AE).
*/

using Exercício_2;

CNH p1 = new CNH("BR");
p1.RecebeIdade(24);
Console.WriteLine($"Seu país é {p1.Pais} , sua idade {p1.Idade} e o tipo de sua carteira {p1.TipoCarteira}\n\n");
CNH p2 = new CNH("US");
p2.RecebeIdade(15);
CNH p3 = new CNH("RU");
p3.RecebeIdade(20);

