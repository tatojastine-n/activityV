using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularShifter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter an integer:");
                }
            }
            Console.Write("\nEnter rotation amount (k): ");
            int k;
            while (!int.TryParse(Console.ReadLine(), out k))
            {
                Console.WriteLine("Invalid input. Please enter an integer:");
            }
            Console.WriteLine("\nOriginal array:");
            PrintArray(numbers);

            int[] rotatedArray = RotateArray(numbers, k);

            Console.WriteLine($"\nArray rotated by {k} positions:");
            PrintArray(rotatedArray);
        }
        static int[] RotateArray(int[] arr, int k)
        {
            int n = arr.Length;
            k = k % n; // Handle cases where k > array length
            if (k < 0) k += n; // Handle negative rotation amounts

            int[] rotated = new int[n];

            for (int i = 0; i < n; i++)
            {
                rotated[(i + k) % n] = arr[i];
            }
            return rotated;
        }
        static void PrintArray(int[] arr)
        {
            Console.Write("[ ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1) Console.Write(", ");
            }
            Console.WriteLine(" ]");
        }
    }
}
