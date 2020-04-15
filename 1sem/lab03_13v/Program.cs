//Перевірити істинність вислову: "Всі цифри даного тризначного числа різні".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3_13v
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false, c;
            int n;
            int[] g = new int[3];

            Console.WriteLine("Welcome!");
            do
            {
                Console.WriteLine("Please, enter the number:");
                c = int.TryParse(Console.ReadLine(), out n);
            } while (c == false || Math.Abs(n) < 100 || Math.Abs(n) > 999);
            n = Math.Abs(n);

            for (int i = 0; i < 3; i++)
            {
                g[i] = n % 10;
                n /= 10;
            }

            if (g[0] != g[1])
            {
                if (g[1] != g[2])
                {
                    if (g[2] != g[0])
                        check = true;
                }
            }

            Console.WriteLine("Each digit of the number is different - {0}", check);

            Console.ReadKey();
        }
    }
}
