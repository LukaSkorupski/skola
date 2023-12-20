using System;

namespace main
{
internal class Program
{

    static void Main(string[] args)
    {
        int[] broji = { 83, 234, 45, 2, 3, 2, 1, 4, 5, 6, 2 };
        Sort.QuickSort(broji, 0, broji.Length - 1);
        foreach (int n in broji)
        {
            Console.Write(String.Format("{0} ", n));
        }
    }
}

class Sort
{

    static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right];
        int i = left - 1;

        for (int j = left; j < right; ++j)
        {
            if (arr[j] <= pivot)
            {
                ++i;
                Swap(arr, i, j);
            }
        }

        Swap(arr, i + 1, right);
        return i + 1;
    }

    public static void QuickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int p = Partition(arr, left, right);
            QuickSort(arr, left, p - 1);
            QuickSort(arr, p + 1, right);
        }
    }

    static void Swap(int[] arr, int a, int b)
    {
        int temp = arr[b];
        arr[b] = arr[a];
        arr[a] = temp;
    }
}
}
