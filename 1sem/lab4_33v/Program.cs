//33.	Дано число A і множина B з N чисел. Знайти номер числа з множини B, 
// найбільш 1) близької; 2) віддаленої  від числа A. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab4_33v
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            int b, n, c, k, diff;
            bool check;

            do
            {
                Console.WriteLine("Welcome! Please, enter the quantity of elements:");
                check = int.TryParse(Console.ReadLine(), out n);
            } while (check == false || n < 2);
            a = new int[n];

            do
            {
                Console.WriteLine("Manual input - 0 \nRandom elements - 1");
                check = int.TryParse(Console.ReadLine(), out c);
            } while (check == false || (c != 1 && c != 0));



            switch (c)
            {
                
                case 0:
                    for (int i = 0; i < n; i++)
                    {
                        do
                        {
                            Console.WriteLine("Input {0} elements:", i+1);
                            check = int.TryParse(Console.ReadLine(), out a[i]);
                        } while (check == false);
                    }

                    Console.WriteLine("Your array:");
                    foreach (int el in a)
                    {
                        Console.Write("{0} ", el);
                    }
                    Console.WriteLine();
                    break;

                case 1:
                    Random rnd = new Random();
                    Console.WriteLine("Your array:");
                    for (int i = 0; i < n; i++)
                    {
                        a[i] = rnd.Next(-100, 100);
                        Console.Write("{0} ", a[i]);
                    }
                    Console.WriteLine();
                    break;
            } 
            

            do
            {
                Console.WriteLine("And now, please, enter the target number:");
                check = int.TryParse(Console.ReadLine(), out b);
            } while (check == false);



            do
            {
                Console.WriteLine("The closest - 0 \nThe farest - 1");
                check = int.TryParse(Console.ReadLine(), out c);
            } while (check == false || (c != 1 && c != 0));

            diff = Math.Abs(b-a[0]);
            k = 0;
            switch (c)
            {
                case 0:
                    for(int i = 1; i < n; i++)
                    {
                        if (Math.Abs(b - a[i]) < diff)
                        {
                            diff =Math.Abs( b - a[i]);
                            k = i;
                        }
                    }
                    Console.WriteLine("The closest - {0}", k+1);
                    break;


                case 1:
                    for (int i = 1; i < n; i++)
                    {
                        if (Math.Abs(b - a[i]) > diff)
                        {
                            diff = Math.Abs(b - a[i]);
                            k = i;
                        }
                    }
                    Console.WriteLine("The farest - {0}", k + 1);
                    break;
            }



            Console.ReadKey();
        }
    }
}
