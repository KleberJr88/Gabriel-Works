using System.Diagnostics;

public class BenchmarkRunner
{
    public static long Run(Action<int[]> algorithm, int[] data)
    {
        int[] copy = (int[])data.Clone();

        Stopwatch sw = new Stopwatch();

        sw.Start();
        algorithm(copy);
        sw.Stop();

        return sw.ElapsedMilliseconds;
    }
}