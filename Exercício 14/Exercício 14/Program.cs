//Faça uma classe Album (de figurinhas) que tem como propriedades a quantidade de figurinhas e um array de
//figurinhasColadas que recebe os números das figurinhas coladas. Garanta que o array de figurinhasColadas apenas 
//pode crescer. Tenha também um método colarFigurinha que permita colar figurinhas que existam no álbum e que não
//foram coladas ainda.

using Exercício_14;
using System.Security.Cryptography;

AlbumDeFigurinhas a1 = new AlbumDeFigurinhas(50);
a1.ColarFigurinhas(4);
a1.ColarFigurinhas(30);
a1.ColarFigurinhas(71);
a1.ColarFigurinhas(1);
a1.ColarFigurinhas(8);
a1.ColarFigurinhas(30);
a1.ColarFigurinhas(67);
a1.ColarFigurinhas(50);
a1.ColarFigurinhas(24);
a1.ColarFigurinhas(25);

a1.MostrarAlbum();
