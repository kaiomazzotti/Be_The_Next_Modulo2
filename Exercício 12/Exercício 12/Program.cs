//Faça uma classe Perfil que tem as seguintes informações: nome, avatar(foto de perfil) e tema.
//Utilize acessors (get/set) para garantir que o tema só pode ser "light" ou "dark" e que a foto de perfil 
//deve ser uma url (iniciada com http ou https).

using Exercício_12;

Perfil p1 = new Perfil("Kaio Mazzotti");
p1.TrocaFotoPerfil();
p1.MudaTema();

Console.WriteLine($"Usuário = {p1.Nome} \nURL foto de Perfil  = [{p1.FotoDePerfil}]\nTema = [{p1.Tema.ToUpper()}]");