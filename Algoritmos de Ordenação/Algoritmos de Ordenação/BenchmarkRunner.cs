using System;
using System.Diagnostics;

public static class BenchmarkRunner
{
    public static void Run(Action<int[]> sortAlgorithm, int[] array)
    {
        const int REPETITIONS = 10;          // número de medições
        const int INTERNAL_LOOPS = 1000;     // execuções internas para gerar carga real

        var process = Process.GetCurrentProcess();
        process.Refresh();

        long ramUsage = process.WorkingSet64;

        TimeSpan cpuBefore = process.TotalProcessorTime;

        Stopwatch sw = Stopwatch.StartNew();

        int[] result = Array.Empty<int>();

        for (int r = 0; r < REPETITIONS; r++)
        {
            for (int i = 0; i < INTERNAL_LOOPS; i++)
            {
                int[] copy = (int[])array.Clone();
                sortAlgorithm(copy);
                result = copy;
            }
        }

        sw.Stop();

        process.Refresh();

        TimeSpan cpuAfter = process.TotalProcessorTime;

        double cpuUsedMs = (cpuAfter - cpuBefore).TotalMilliseconds;
        double totalTimeMs = sw.Elapsed.TotalMilliseconds;

        double cpuPercent = 0;

        if (totalTimeMs > 0)
        {
            cpuPercent = (cpuUsedMs / totalTimeMs) / Environment.ProcessorCount * 100;
        }

        Console.WriteLine($"Repetições do teste: {REPETITIONS}");
        Console.WriteLine($"Execuções internas por repetição: {INTERNAL_LOOPS}");
        Console.WriteLine($"Tempo total: {totalTimeMs:F6} ms");
        Console.WriteLine($"CPU utilizada: {cpuPercent:F6}%");
        Console.WriteLine($"RAM utilizada pelo processo: {ramUsage} bytes");

        Console.WriteLine("Resultado ordenado:");
        Console.WriteLine(string.Join(" ", result));
    }
}