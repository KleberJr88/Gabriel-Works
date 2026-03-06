public class MergeSort
{
    public static void Sort(int[] array)
    {
        MergeSortRecursive(array, 0, array.Length - 1);
    }

    private static void MergeSortRecursive(int[] array, int left, int right)
    {
        if (left >= right)
            return;

        int mid = (left + right) / 2;

        MergeSortRecursive(array, left, mid);
        MergeSortRecursive(array, mid + 1, right);

        Merge(array, left, mid, right);
    }

    private static void Merge(int[] array, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];

        int i = left;
        int j = mid + 1;
        int k = 0;

        while (i <= mid && j <= right)
        {
            if (array[i] <= array[j])
                temp[k++] = array[i++];
            else
                temp[k++] = array[j++];
        }

        while (i <= mid)
            temp[k++] = array[i++];

        while (j <= right)
            temp[k++] = array[j++];

        for (int t = 0; t < temp.Length; t++)
            array[left + t] = temp[t];
    }
}