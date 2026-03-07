using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===== Benchmark de Ordenação =====");

        Console.WriteLine("\nEscolha o algoritmo:");
        Console.WriteLine("1 - QuickSort");
        Console.WriteLine("2 - MergeSort");

        int choice = int.Parse(Console.ReadLine());

        Action<int[]> algorithm;
        string name;

        if (choice == 1)
        {
            algorithm = QuickSort.Sort;
            name = "QuickSort";
        }
        else
        {
            algorithm = MergeSort.Sort;
            name = "MergeSort";
        }

        Console.WriteLine("\n===== Vetor Normal (3 posições) =====");

        int[] normalArray = ArrayGenerator.ReadArrayFromUser(3);

        BenchmarkRunner.Run(name, algorithm, normalArray);

        Console.WriteLine("\n===== Vetor Estendido (5 posições) =====");

        int[] extendedArray = ArrayGenerator.ReadArrayFromUser(5);

        BenchmarkRunner.Run(name, algorithm, extendedArray);

        Console.WriteLine("Pressione ENTER para sair...");
        Console.ReadLine();
    }
}