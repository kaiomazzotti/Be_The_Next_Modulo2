//Construa uma classe Programa com as propriedades nome e generos (ação, comédia, suspense, drama, terror) 
//e duas classes que herdam desta (Seriado e Filme). A classe Seriado deve ter numeroDeEpisodios (de 1 a n),
//anoDeInicio e anoDeFim. Já a classe Filme precisa ter a duracao (em minutos).

using Exercício_16;

Filme f1 = new Filme("AS BRANQUELAS", "comédia", 156 );
f1.Apresentar();
Seriado s1 = new Seriado("Monk", "comédia", 76, 2001, 2012);
s1.Apresentar();