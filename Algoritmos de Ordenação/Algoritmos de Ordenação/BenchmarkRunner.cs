using System;
using System.Diagnostics;

public static class BenchmarkRunner
{
    public static void Run(string algorithmName, Action<int[]> algorithm, int[] data)
    {
        int[] copy = (int[])data.Clone();

        Process process = Process.GetCurrentProcess();

        TimeSpan cpuBefore = process.TotalProcessorTime;
        long memBefore = process.WorkingSet64;

        Stopwatch sw = Stopwatch.StartNew();

        algorithm(copy);

        sw.Stop();

        TimeSpan cpuAfter = process.TotalProcessorTime;
        long memAfter = process.WorkingSet64;

        double cpuUsedMs = (cpuAfter - cpuBefore).TotalMilliseconds;
        double cpuPercentage = cpuUsedMs / (Environment.ProcessorCount * sw.ElapsedMilliseconds) * 100;

        long memUsed = memAfter - memBefore;

        double totalRam = GC.GetGCMemoryInfo().TotalAvailableMemoryBytes;
        double ramPercentage = (memUsed / totalRam) * 100;

        Console.WriteLine($"\nAlgoritmo: {algorithmName}");
        Console.WriteLine($"Tempo: {sw.ElapsedMilliseconds} ms");
        Console.WriteLine($"CPU usada: {cpuPercentage:F2}%");
        Console.WriteLine($"RAM usada: {ramPercentage:F6}%");

        Console.WriteLine("Resultado ordenado:");
        foreach (var n in copy)
            Console.Write(n + " ");

        Console.WriteLine("\n");
    }
}