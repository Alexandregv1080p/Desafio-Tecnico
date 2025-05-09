using System;

class Program
{
    static bool Fibonacci(int num)
    {
        int a = 0;
        int b = 1;

        if (num == 0 || num == 1)
        {
            return true;
        }

        while (b < num)
        {
            int temp = b;
            b = a + b;
            a = temp;
        }

        return b == num;
    }

    static void Main()
    {
        int numeroInformado = 6;

        if (Fibonacci(numeroInformado))
        {
            Console.WriteLine($"O número {numeroInformado} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numeroInformado} NÃO pertence à sequência de Fibonacci.");
        }
    }
}
