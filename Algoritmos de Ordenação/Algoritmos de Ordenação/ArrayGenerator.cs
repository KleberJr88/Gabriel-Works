public class ArrayGenerator
{
    public static int[] RandomArray(int size)
    {
        Random rand = new Random();
        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
            arr[i] = rand.Next(0, 100000);

        return arr;
    }

    public static int[] SortedArray(int size)
    {
        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
            arr[i] = i;

        return arr;
    }

    public static int[] ReversedArray(int size)
    {
        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
            arr[i] = size - i;

        return arr;
    }
}