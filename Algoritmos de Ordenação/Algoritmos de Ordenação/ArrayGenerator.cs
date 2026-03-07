using System;

public static class ArrayGenerator
{
    public static int[] ReadArrayFromUser(int size)
    {
        int[] arr = new int[size];

        Console.WriteLine($"\nDigite {size} números:");

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Número {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        return arr;
    }
}