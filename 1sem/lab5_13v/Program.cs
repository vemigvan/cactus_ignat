//13. Дана квадратна матриця порядку M. Знайти суму елементів її 1)
//головної; 2) побічної діагоналей.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pd21_23._09_lychanyi_lab5_v13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix;
            int n, sum = 0, sw;
            bool check;

            do
            {
                Console.WriteLine("Welcome! Please, enter the quantity of rows and colomns: ");
                check = int.TryParse(Console.ReadLine(), out n);
            } while (check != true || n < 2);

            matrix = new int[n, n];


            Console.WriteLine("The Matrix:");
            Random ran = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = ran.Next(0, 100);
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Find the summ of main diagonal - 0 \nFind the summ of secondary diagonal - 1");
            do
            {
                check = int.TryParse(Console.ReadLine(), out sw);
            } while (check != true || (sw != 0 && sw != 1));


            switch (sw)
            {
                case 0:
                    for (int i = 0; i < n; i++)
                    {
                        sum += matrix[i, i];
                    }
                    Console.WriteLine("The summ of main diagonal is {0}", sum);
                    break;
                case 1:
                    for (int i = n - 1; i >= 0; i--)
                    {
                        sum += matrix[n - 1 - i, i];
                    }
                    Console.WriteLine("The summ of secondary diagonal is {0}", sum);
                    break;
            }

            Console.ReadKey();
        }
    }
}