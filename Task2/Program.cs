using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int lowerBound = 0;
            int upperBound = 50;
            const int sizeArr = 15;
            int[] arr = new int[sizeArr];

            Random rand = new Random();
            int max = lowerBound, min = upperBound;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(lowerBound, upperBound);
                Console.Write($"{arr[i]} ");
                max = arr[i] > max ? arr[i] : max;
                min = arr[i] < min ? arr[i] : min;                
            }
            Console.Write($"\nСумма максимального и минимального значения: {max}+{min}={max + min}");
            Console.ReadKey();

        }
    }
}
