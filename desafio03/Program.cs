using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    public class Faturamento
    {
        public string dia { get; set; }
        public double valor { get; set; }
    }

    static void Main()
    {
        string json = File.ReadAllText("faturamento.json");

        var dados = JsonConvert.DeserializeObject<List<Faturamento>>(json);

        var diasComFaturamento = dados.FindAll(item => item.valor > 0);


        double menorFaturamento = double.MaxValue;
        foreach (var item in diasComFaturamento)
        {
            if (item.valor < menorFaturamento)
            {
                menorFaturamento = item.valor;
            }
        }


        double maiorFaturamento = double.MinValue;
        foreach (var item in diasComFaturamento)
        {
            if (item.valor > maiorFaturamento)
            {
                maiorFaturamento = item.valor;
            }
        }

        double soma = 0;
        foreach (var item in diasComFaturamento)
        {
            soma += item.valor;
        }
        double media = soma / diasComFaturamento.Count;

        int diasAcimaDaMedia = 0;
        foreach (var item in diasComFaturamento)
        {
            if (item.valor > media)
            {
                diasAcimaDaMedia++;
            }
        }

        Console.WriteLine($"Menor faturamento do mês: R$ {menorFaturamento:F2}");
        Console.WriteLine($"Maior faturamento do mês: R$ {maiorFaturamento:F2}");
        Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}
