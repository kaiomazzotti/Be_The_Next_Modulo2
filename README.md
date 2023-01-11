# Be_The_Next_Modulo2
### Exercícios do Módulo 2 do curso da Ada

#### Exercício 1 
Construa uma classe Boletim para uma faculdade com as propriedades: nome (do aluno), ano (maior que 1964), semestre(de 1 a 14) e um List com as médias de 6 máterias.

#### Exercício 2
Construa uma classe CNH que tenha como propriedades país e idade que, por padrão, deve ser maior ou igual a 18,

 16 se país for igual a US ou CA e
 21 se páis corresponder a CH ou RU.

 Se o país for BR deve também ser informada a
 categoria da carteira (A, B, C, D, E, AB, AC, AD ou AE).

#### Exercício 8
Crie uma classe Carro que tenha as propriedades: cor, marca, modelo (sedan ou hatch), capacidadeDoTanque (em litros), tipoDeCombustível (gasolina, álcool ou flex) e um método abastecer que respeite o tipo de combustível que o automóvel aceita e a capacidade máxima de litros.

Além de abastecer o carro, também devemos ter o preço do abastecimento (gasolina = R$ 5,62/L e etanol = R$ 4,16/L)

#### Exercício 9
Crie uma classe Time que tenha como propriedade o nome do país, nome do esporte e a pontuação dele em um torneio. Sua pontuação pode ser acrescida por um método pontua que recebe como parâmetro "W" para vitória (+3 pontos), "L" para derrota (+0 pontos) e "D" para empate (+1 ponto).

#### Exercício 10
Deseja-se montar uma classe Sorteio que tem o número de pessoas inscritas e um método sorteiaPremio que sorteia um número que corresponderá ao número de inscrição do participante e declara o vencedor.

#### Exercício 11
Crie uma classe Restaurante com as propriedades cidade, delivery (verdadeiro ou falso), pedidosPendentes e tempo de entrega estimado (calculado com base nos pedidos pendentes, sendo 10 + 2 * pedidosPendentes em minutos). Os restaurantes devem ser capazes de realizar entregas desde que o cliente esteja localizado na mesma cidade e, para isso, precisamos de um método entregaPedido que devolve como resultado se é possível realizar a entrega para um determinado cliente ou não e, em caso positivo, o tempo estimado de entrega.

#### Exercício 12
Faça uma classe Perfil que tem as seguintes informações: nome, avatar (foto de perfil) e tema. Utilize acessors (get/set) para garantir que o tema só pode ser "light" ou "dark" e que a foto de perfil deve ser uma url (iniciada com http ou https).

#### Exercício 13 
Faça uma classe SmartWatch com a contagem dos passos diários de uma pessoa (pedômetro). Garanta utilizando acessors (get/set) que os passos apenas podem ser incrementados e um método resetOnMidnight() que reseta os passos para 0.

#### Exercício 14 
Faça uma classe Album (de figurinhas) que tem como propriedades a quantidade de figurinhas e um array de figurinhasColadas que recebe os números das figurinhas coladas. Garanta que o array de figurinhasColadas apenas pode crescer. Tenha também um método colarFigurinha que permita colar figurinhas que existam no álbum e que não foram coladas ainda.

#### Exercício 15 
Construa uma classe Veiculo que tem como propriedades rodas (1 a n), usaCombustivel (true/false), uma classe Carro (tipoDecombustivel: 'gasolina', 'álcool', 'flex') que herda de Veiculo e Bicicleta (infantil: true/false - tem que ter mais que 2 rodas) que também herda as características de Veiculo.

#### Exercício 16 
Construa uma classe Programa com as propriedades duracao e generos (ação, comédia, suspense, drama, terror) e duas classes que herdam desta (Seriado e Filme). A classe Seriado deve ter numeroDeEpisodios (de 1 a n), anoDeInicio e anoDeFim. Já a classe Filme precisa ter a duracao (em minutos).

#### Exercício 17
Crie uma classe Livro com as propriedades autor e ano. Crie também as classes Ebook e AudioBook que herdam de Livro. Ebook deve ter numero de páginas e número de capítulos. Já a classe AudioBook deve ter a duração total do áudio em minutos.

#### Exercício 18 
Crie uma classe Camera que deve ter como propriedades resolucaoMaxima e fotosTiradas e um método tiraFoto que apenas aumenta o número de fotos tiradas. Crie uma classe Celular que tenha como propriedades espacoDisponivel (em número de fotos), cameraFrontal e cameraTraseira. Tanto a cameraFrontal como a cameraTraseira devem ser classes que herdam de Camera e tem como propriedades adicionais a resolucaoAtual (não pode ser superior à resolucaoMaxima). Ambas apenas podem tirar fotos se houver espaço disponível no celular e a cameraFrontal deve ter resolucaoMaxima menor que a cameraTraseira.
