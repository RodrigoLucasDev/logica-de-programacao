using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine("Escolha a operação (+, -, *, /, %)");
        string z = Console.ReadLine();
        switch (z)
        {
            case "+":
                Console.WriteLine(x + y);
            break;
            case "-":
                Console.WriteLine(x - y);
            break;
            case "*":
                Console.WriteLine(x * y);
            break;
            case "/":
                Console.WriteLine(x / y);
            break;
            case "%":
                Console.WriteLine(x % y);
            break;
        }
    }
}