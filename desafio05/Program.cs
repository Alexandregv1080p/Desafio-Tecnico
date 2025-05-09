using System;

class Program
{
    static string InverterString(string texto)
    {
        string invertida = "";
        
        for (int i = texto.Length - 1; i >= 0; i--)
        {
            invertida += texto[i];
        }

        return invertida;
    }

    static void Main()
    {
        string original = "Exemplo de string";

        string resultado = InverterString(original);

        Console.WriteLine("Original: " + original);
        Console.WriteLine("Invertida: " + resultado);
    }
}
