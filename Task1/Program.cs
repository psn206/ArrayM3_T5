using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];
            double arithmeticMean = 0;
            Console.WriteLine("Введите 7 чисел:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                arithmeticMean += arr[i] /(double) arr.Length;               
            }
            Console.WriteLine("{0} {1:f2} ", "Среднее арифметическое:", arithmeticMean);
            Console.ReadKey();  
        }
        
    }
}
