string nome, nome2, help;

Console.WriteLine("Troca de Valores");

Console.Write("Nome---");
nome = Console.ReadLine()!;

Console.Write("Nome2---");
nome2 = Console.ReadLine()!;

help = nome;
nome = nome2;
nome2 = help;


Console.WriteLine("Trocando os valores");
Console.WriteLine($"nome = {nome}");
Console.WriteLine($"nome2 = {nome2}");