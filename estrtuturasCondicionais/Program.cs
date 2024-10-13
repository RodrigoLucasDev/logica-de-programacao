/*
Crie um programa em C# que solicite ao usuário a nota de um aluno (entre 0 e 100) e, com base nessa nota, exiba a seguinte avaliação:
- Se a nota for maior ou igual a 90, exibir "A".
- Se a nota for maior ou igual a 80 e menor que 90, exibir "B".
- Se a nota for maior ou igual a 70 e menor que 80, exibir "C".
- Se a nota for maior ou igual a 60 e menor que 70, exibir "D".
- Se a nota for menor que 60, exibir "F".
*/
using System;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Digite a nota do aluno:");
        int nota = int.Parse(Console.ReadLine());
        if (nota >= 90)
        {
            Console.WriteLine("Nota: A");
        }
        else if (nota >= 80 && nota < 90)
        {
            Console.WriteLine("Nota: B");
        }
        else if (nota >= 70 && nota < 80)
        {
            Console.WriteLine("Nota: C");
        }
        else if (nota >= 60 && nota <70)
        {
            Console.WriteLine("Nota: D");
        }
        else if (nota < 60)
        {
            Console.WriteLine("Nota: F");
        }
    }
}

