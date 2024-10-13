using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor de n (quantidade de números da sequência de Fibonacci que deseja ver): ");
        int n = int.Parse(Console.ReadLine());

        int primeiro = 0, segundo = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(primeiro + " ");

            int proximo = primeiro + segundo;
            primeiro = segundo;
            segundo = proximo;
        }

        Console.WriteLine();  
    }
}
