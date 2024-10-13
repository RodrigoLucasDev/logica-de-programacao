/*### **Desafio de Código: Calculadora Modularizada**

Crie um programa em C# que funcione como uma calculadora modularizada. O programa deve ter os seguintes métodos:

- **Somar(int a, int b)**: Retorna a soma de dois números.
- **Subtrair(int a, int b)**: Retorna a subtração de dois números.
- **Multiplicar(int a, int b)**: Retorna a multiplicação de dois números.
- **Dividir(int a, int b)**: Retorna a divisão de dois números.

O programa deve permitir ao usuário escolher a operação desejada, informar os números e exibir o resultado. */
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine("Escolha a operação (+, -, *, /)");
        string z = Console.ReadLine();
        switch (z)
        {
            case "+":
                Console.WriteLine(Somar(x, y));
                break;
            case "-":
                Console.WriteLine(Subtrair(x, y));
                break;
            case "*":
                Console.WriteLine(Multiplicar(x, y));
                break;
            case "/":
                Console.WriteLine(Dividir(x, y));
                break;
        }
    }
    public static int Somar(int x, int y)
    {
        int resultado = x + y;
        return resultado;
    }
    public static int Subtrair(int x, int y)
    {
        int resultado = x - y;
        return resultado;
    }
    public static int Multiplicar(int x, int y)
    {
        int resultado = x * y;
        return resultado;
    }
    public static int Dividir(int x, int y)
    {
        int resultado = x / y;
        return resultado;
    }
}
