using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===== Benchmark de Ordenação =====");

        Console.WriteLine("\nEscolha o algoritmo:");
        Console.WriteLine("1 - QuickSort");
        Console.WriteLine("2 - MergeSort");

        int choice = int.Parse(Console.ReadLine() ?? "1");

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

        Console.WriteLine($"\nAlgoritmo: {name}");
        BenchmarkRunner.Run(algorithm, normalArray);

        Console.WriteLine("\n===== Vetor Estendido (5 posições) =====");

        int[] extendedArray = ArrayGenerator.ReadArrayFromUser(5);

        Console.WriteLine($"\nAlgoritmo: {name}");
        BenchmarkRunner.Run(algorithm, extendedArray);

        Console.WriteLine("\nPressione ENTER para sair...");
        Console.ReadLine();
    }
}