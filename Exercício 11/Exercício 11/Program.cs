﻿//Crie uma classe Restaurante com as propriedades cidade, delivery (verdadeiro ou falso), pedidosPendentes e 
//tempo de entrega estimado (calculado com base nos pedidos pendentes, sendo 10 + 2 * pedidosPendentes em minutos).
//Os restaurantes devem ser capazes de realizar entregas desde que o cliente esteja localizado na mesma cidade e,
//para isso, precisamos de um método entregaPedido que devolve como resultado se é possível realizar a entrega 
//para um determinado cliente ou não e, em caso positivo, o tempo estimado de entrega.

using Exercício_11;

Restaurante LancheDoGordo = new Restaurante("Indaiatuba", true);
LancheDoGordo.Entrega();
LancheDoGordo.Entrega();
LancheDoGordo.Entrega();
LancheDoGordo.Entrega();

Console.WriteLine("Pedidos pendentes: " + LancheDoGordo.PedidosPendentes);

Restaurante LancheDoGordo2 = new Restaurante("Indaiatuba", false);
LancheDoGordo2.Entrega();