class Program
{
    static void Main()
    {
        Console.Write("Digite a placa do veículo: ");
        string? placa = Console.ReadLine();

        bool isPlacaValida = VerificarPlaca(placa);
        Console.WriteLine(isPlacaValida ? "Verdadeiro" : "Falso");
        Console.ReadKey();
    }

    static bool VerificarPlaca(string? placa)
    {
        if (string.IsNullOrEmpty(placa) || placa.Length != 7)
        {
            return false;
        }

        for (int i = 0; i < 3; i++)
        {
            if (!char.IsLetter(placa[i]))
            {
                return false;
            }
        }

        for (int i = 3; i < 7; i++)
        {
            if (!char.IsDigit(placa[i]))
            {
                return false;
            }
        }

        return true;
    }
}
