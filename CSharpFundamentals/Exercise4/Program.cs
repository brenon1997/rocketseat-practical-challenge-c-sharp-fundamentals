Console.Write("Digite uma ou mais palavras: ");
string? input = Console.ReadLine();

int contador = 0;

if (input != null)
{
    foreach (char c in input)
    {
        if (char.IsLetter(c))
        {
            contador++;
        }
    }
}

Console.WriteLine($"Quantidade de caracteres (sem espaços): {contador}");
Console.ReadKey();