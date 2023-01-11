//Construa uma classe Veiculo que tem como propriedades rodas (1 a n),
//usaCombustivel(true / false), uma classe Carro (tipoDecombustivel: 'gasolina', 'álcool', 'flex')
//que herda de Veiculo e Bicicleta (infantil: true / false - tem que ter mais que 2 rodas) 
//que também herda as características de Veiculo.

using Exercício_15;

Carro c1 = new Carro(3,false,"álcool");
Console.WriteLine($"rodas {c1.Rodas} , usa combústivel? {c1.UsaCombustível} , tipo de combustível {c1.TipoCombustivel}");
Bicicleta b1 = new Bicicleta(2, false, true);
Console.WriteLine($"rodas {b1.Rodas} , usa combústivel? {b1.UsaCombustível} , é infantil? {b1.Criança}");
