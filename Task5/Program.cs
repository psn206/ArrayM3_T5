using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите размер массива NхN \nN= ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = (i == j || i + j == n - 1) ? 1 : 0;
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
