using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическое_занятие_10._1._1
{
    class Program
    {
        static void Main (string[] args)
        {
            //var 18

            Console.WriteLine("Введите M: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите K: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите K1: ");
            int k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите K2: ");
            int k2 = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Введите элемент матрицы [{i}, {j}]");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Матрица выглядит так: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }


        }
    }
}
