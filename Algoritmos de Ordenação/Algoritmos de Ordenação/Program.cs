using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] sizes = { 1000, 5000, 10000 };

        foreach (var size in sizes)
        {
            var random = ArrayGenerator.RandomArray(size);

            long quickTime = BenchmarkRunner.Run(QuickSort.Sort, random);
            long mergeTime = BenchmarkRunner.Run(MergeSort.Sort, random);

            Console.WriteLine($"Size: {size}");
            Console.WriteLine($"QuickSort: {quickTime} ms");
            Console.WriteLine($"MergeSort: {mergeTime} ms");
        }
    }
}