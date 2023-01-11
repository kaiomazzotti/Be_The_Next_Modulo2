//Crie uma classe Livro com as propriedades autor e ano. Crie também as classes Ebook e AudioBook que herdam de Livro.
//Ebook deve ter numero de páginas e número de capítulos. Já a classe AudioBook deve ter a duração total do áudio
//em minutos.

using Exercício_17;

AudioBook a1 = new AudioBook("O dia em que o mundo virou vermelho","Adriano Gabiru", 2006, 90);
a1.Apresentar();
Ebook e1 = new Ebook("The Witcher", "A. Sapkowski", 2017, 269, 15);
e1.Apresentar();