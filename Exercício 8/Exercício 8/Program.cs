//Crie uma classe Carro que tenha as propriedades: cor, marca, modelo(sedan ou hatch),
//    capacidadeDoTanque(em litros), tipoDeCombustível(gasolina, álcool ou flex) 
//    e um método abastecer que respeite o tipo de combustível que o automóvel aceita
//    e a capacidade máxima de litros.

//Além de abastecer o carro, também devemos ter o preço do abastecimento
//(gasolina = R$ 5,62/L e etanol = R$ 4,16/L)

using Exercício_8;

Carro c1 = new Carro("Vermelho", "chevrolet", "hatch", 50, "flex");
int abastecimento = c1.Abastecer();
Console.WriteLine($"Seu carro de marca {c1.Marca}, modelo {c1.Modelo} e cor {c1.Cor} tem capacidade de {c1.CapacidadeDoTanque} litros e está abastecido com {abastecimento} litros");