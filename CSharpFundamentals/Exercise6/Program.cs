using System.Globalization;

class Program
{
    static void Main()
    {
        DateTime dataAtual = DateTime.Now;
        CultureInfo cultura = new CultureInfo("pt-BR");

        Console.WriteLine("Data completa:");
        Console.WriteLine(dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss", cultura));

        Console.WriteLine("\nData no formato 'dd/MM/yyyy':");
        Console.WriteLine(dataAtual.ToString("dd/MM/yyyy", cultura));

        Console.WriteLine("\nHora no formato de 24 horas:");
        Console.WriteLine(dataAtual.ToString("HH:mm", cultura));

        Console.WriteLine("\nData com mês por extenso:");
        Console.WriteLine(dataAtual.ToString("dd 'de' MMMM 'de' yyyy", cultura));

        Console.ReadKey();
    }
}