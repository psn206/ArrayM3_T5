using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива NхN \nN= ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            int[,] arr = new int[n, n];
            int[] magic = new int[2 * n + 2];
            int positionCursorLeft = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    positionCursorLeft = Console.CursorLeft;
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(positionCursorLeft + Convert.ToString(arr[i, j]).Length, Console.CursorTop - 1);
                    Console.Write(" ");
                    magic[i] += arr[i, j];
                    magic[i + n] += arr[j, i];
                    if (i == j)
                    {
                        magic[2 * n + 1] += arr[i, j];
                    }
                    if (i + j == n)
                    {
                        magic[2 * n + 1] += arr[i, j];
                    }
                }
                Console.WriteLine();
            }
            for (int i = 1; i < magic.Length; i++)
            {
                if (magic[0] == magic[i])
                {
                    flag = true;
                }
            }
            if (flag)
            {
                Console.WriteLine("Являтся магическим квадратом!");
            }
            else { Console.WriteLine("Увы, это не магический квадрат!"); }
            Console.ReadKey();
        }
    }
}
