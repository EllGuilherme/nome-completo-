string nome, sobrenome, sobrenomeemmaiusculo;
Console.Write("digite seu primeiro nome:");
nome = Console.ReadLine()!;

Console.Write("digete seu segundo nome: ");
sobrenome = Console.ReadLine()!;

sobrenomeemmaiusculo = sobrenome.ToUpper();

Console.WriteLine($"nome completo: {nome} {sobrenome}");
Console.WriteLine($"nome de catalogo: {sobrenomeemmaiusculo}, {nome}");