
using System;
 public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the numbers to be sorted, separated by spaces:");
        string input = Console.ReadLine();
         if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid input. Please enter valid numbers separated by spaces.");
            return;
        }
         int[] array;
         try
        {
            array = Array.ConvertAll(input.Split(' '), int.Parse);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter valid numbers separated by spaces.");
            return;
        }
         MergeSort(array);
         Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(" ", array));
    }
     private static void MergeSort(int[] array)
    {
        if (array == null || array.Length <= 1)
            return;
         int mid = array.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[array.Length - mid];
         // Copy elements to the left and right subarrays
        Array.Copy(array, 0, left, 0, mid);
        Array.Copy(array, mid, right, 0, array.Length - mid);
         // Recursive calls for sorting the subarrays
        MergeSort(left);
        MergeSort(right);
         // Merge the sorted subarrays back into the original array
        Merge(left, right, array);
    }
     private static void Merge(int[] left, int[] right, int[] array)
    {
        int i = 0, j = 0, k = 0;
         while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                array[k] = left[i];
                i++;
            }
            else
            {
                array[k] = right[j];
                j++;
            }
            k++;
        }
         while (i < left.Length)
        {
            array[k] = left[i];
            i++;
            k++;
        }
         while (j < right.Length)
        {
            array[k] = right[j];
            j++;
            k++;
        }
    }
}