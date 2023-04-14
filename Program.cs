using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
  int[,] notas = new int[3, 4];

for (int linha = 0; linha < 3; linha++)
{
    Console.WriteLine("Insira as notas do aluno " + (linha+1) + ":");

    for (int coluna = 0; coluna < 4; coluna++)
    {
        Console.Write("Nota " + (coluna+1) + ": ");
        notas[linha, coluna] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("\nTabela de notas:");

for (int linha = 0; linha < 3; linha++)
{
    for (int coluna = 0; coluna < 4; coluna++)
    {
        Console.Write(notas[linha, coluna] + " ");
    }
    Console.WriteLine();
}

            }
        }
    }
