Console.Write("Digite seu nome: ");
string? nome = Console.ReadLine();

Console.Write("Digite seu sobrenome: ");
string? sobrenome = Console.ReadLine();
if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(sobrenome))
{
    Console.WriteLine("Nome ou sobrenome inválidos. Por favor, digite valores válidos.");
}
else
{
    string nomeCompleto = nome + " " + sobrenome;
    Console.WriteLine($"Nome completo: {nomeCompleto}");
}

Console.ReadKey();