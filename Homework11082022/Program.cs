using System;

class Homework
{
    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[min_idx])
                {
                    min_idx = j;
                }
            }
            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }
    }
    static void PrintArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    static void BubbleSort(int[] arr1)
    {
        int n = arr1.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
                if (arr1[j] > arr1[j + 1])
                {
                    int temp = arr1[j];
                    arr1[j] = arr1[j + 1];
                    arr1[j + 1] = temp;
                }
        }
    }
    static void InsertionSort(int[] arr2)
    {
        int n = arr2.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr2[i];
            int j = i - 1;

            while (j >= 0 && arr2[j] > key)
            {
                arr2[j + 1] = arr2[j];
                j = j - 1;
            }
            arr2[j + 1] = key;
        }
    }
    public static void Main()
    {
        int[] arr1 = { 64, 24, 11, 21, 10 };
        int[] arr2 = { 63, 33, 24, 11, 89 };
        int[] arr3 = { 11, 10, 12, 4, 5 };

        SelectionSort(arr1);
        BubbleSort(arr2);
        InsertionSort(arr3);

        Console.WriteLine("Selection Sort");
        PrintArray(arr1);
        Console.WriteLine("Bubble Sort");
        PrintArray(arr2);
        Console.WriteLine("Insertion Sort");
        PrintArray(arr3);

    }

}