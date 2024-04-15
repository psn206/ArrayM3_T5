using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowerBound = -50;
            int upperBound = 50;
            int k=0;
            const int sizeArr = 20;
            int[] arr = new int[sizeArr];

            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(lowerBound, upperBound);
                Console.Write($"{arr[i]} ");
                if (arr[i]%2!=0 && arr[i]>0 && i%2==0)
                {
                    k++;
                }
            }
            Console.WriteLine($"\nКоличество нечетных положительных элементов, стоящих на четных местах - {k}");
            Console.ReadKey();
        }
    }
}
