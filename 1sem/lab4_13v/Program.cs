
//13.	Даний масив розміру N. Знайти кількість його локальних мінімумів (максимумів). 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace lab4_13v
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a;
            int n, k = 0, c, i = 0;
            bool check;
            do
            {
                Console.WriteLine("Welcome! Please, enter the quantity of elements:");
                check = int.TryParse(Console.ReadLine(), out n);
            } while (check == false || n < 1);
            a = new double[n];

            Random rnd = new Random();
            for (i = 0; i < n; i++)
            {
                a[i] = rnd.Next(100);
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();



            do
            {
                Console.WriteLine("Find the quantity of local minimums - 0");
                Console.WriteLine("Find the quantity of local maximums - 1");
                string s = Console.ReadLine();
                check = int.TryParse(s, out c);
            } while (check != false || (c != 0 && c != 1));


            switch (c)
            {
                case 0:


                    i = 0;
                    if (n != 1 && a[i] < a[i + 1])
                        k++;

                    i++;
                    for (i = 1; i < n - 1; i++)
                    {
                        if (a[i] < a[i - 1] && a[i] < a[i + 1])
                            k++;
                    }
                    if (n != 1 && a[i] < a[i - 1])
                        k++;
                    Console.WriteLine("The quantity of local minimums is {0}", k);
                    break;


                case 1:
                    i = 0;
                    if (n != 1 && a[i] > a[i + 1])
                        k++;

                    i++;
                    for (i = 1; i < n - 1; i++)
                    {
                        if (a[i] > a[i - 1] && a[i] > a[i + 1])
                            k++;
                    }
                    if (n != 1 && a[i] > a[i - 1])
                        k++;
                    Console.WriteLine("The quantity of local maximums is {0}", k);
                    break;
            }


            Console.ReadKey();
        }


    }
}



