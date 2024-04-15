using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int lowerBound = -50;
            int upperBound = 50;
            const int sizeArr = 10;
            int[] arr = new int[sizeArr];
            Random rand = new Random();
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(lowerBound, upperBound);
                Console.Write($"{arr[i]} ");
            }
            for (int i = 0; i < (arr.Length - 1) / 2; i++)
            {
                for (int j = i + 1; j < (arr.Length) / 2; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = arr.Length / 2; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine($"\nМассив после сортировки:"); ;
            foreach (var a in arr)
            {
                Console.Write($"{a} ");
            }
            Console.ReadKey();







        }
    }
}
