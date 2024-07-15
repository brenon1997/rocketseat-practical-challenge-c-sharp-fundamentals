double num1 = 6.1;
double num2 = 1.2;

double soma = num1 + num2;
Console.WriteLine($"Soma: {num1} + {num2} = {soma:F2}");

double subtracao = num1 - num2;
Console.WriteLine($"Subtração: {num1} - {num2} = {subtracao:F2}");

double multiplicacao = num1 * num2;
Console.WriteLine($"Multiplicação: {num1} * {num2} = {multiplicacao:F2}");

if (num2 != 0)
{
    double divisao = num1 / num2;
    Console.WriteLine($"Divisão: {num1} / {num2} = {divisao:F2}");
}
else
{
    Console.WriteLine("Erro: Divisão por zero não é permitida.");
}

double media = (num1 + num2) / 2;
Console.WriteLine($"Média: ({num1} + {num2}) / 2 = {media:F2}");