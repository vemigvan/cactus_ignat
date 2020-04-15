
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab7_1v
{
    class Program
    {
        static int Reverse(int a)
        {
            string src, res="";
            int k = 1;
            if (a < 0)
            {
                a *= -1;
                k = -1;
            }
            src = a.ToString();
            for(int i = src.Length-1; i >= 0; i--)
            {
                res += src[i];
            }
            int.TryParse(res, out a);
            a *= k;

            return a;
        }



        static string Reverse(string src)
        {
            string res = "";
            for (int i = src.Length - 1; i >= 0; i--)
            {
                res += src[i];
            }

            return res;
        }


        static double Reverse(double a)
        {
            string src, res = "";
            int k = 1;
            if (a < 0)
            {
                a *= -1;
                k = -1;
            }
            src = a.ToString();
            for (int i =0; src[i] != '.'; i++)
            {
                res += src[i];
            }
            res = Reverse(res);
            res += ".";
            for (int i = src.Length - 1; src[i] != '.'; i--)
            {
                res += src[i];
            }


            double.TryParse(res, out a);
            a *= k;

            return a;
        }


        static string Reverse(string src, char p)
        {
            string res = "";
            int i,j = 0;
            for (i = 0;src[i] != p; i++)
            {
                res += src[i];
            }
            j = i;
            res = Reverse(res);
            res += p;
            for ( i = src.Length - 1; i != j; i--)
            {
                res += src[i];
            }
            return res;
        }

        static void Reverse(ref string[] src) //Ну, тут можно было потом вернуть целый массив, но раз нужен ref... 
        {
            int q=0;
            foreach (string el in src)
            {
                q++;
            }
            string[] res = new string[q];
            for(int i = 0; i < q; i++)
            {
                res[i] = src[q - i - 1];
            }
            src = res;

        }



        static void Main(string[] args)
        {
            int op;
            bool check;


            Console.WriteLine("Welcome! Please, select option:");
            Console.WriteLine("\t1 - Reverse a number");
            Console.WriteLine("\t2 - Reverse a number with a point");
            Console.WriteLine("\t3 - Reverse a text");
            Console.WriteLine("\t4 - Reverse a text with special character");
            Console.WriteLine("\t5 - Reverse an array");

            do
            {
                check = int.TryParse(Console.ReadLine(), out op);
            } while (check != true || (op<1 || op>5));

            switch (op)
            {
                case 1:
                    int num;
                    Console.Write("Please, enter the number: ");
                    do
                    {
                        check = int.TryParse(Console.ReadLine(), out num);
                    } while (check != true);
                    Console.Write("Your reversed number - {0}", Reverse(num));
                    break;

                case 2:
                    double fnum;
                    Console.Write("Please, enter the number: ");
                    do
                    {
                        check = double.TryParse(Console.ReadLine(), out fnum);
                    } while (check != true);
                    Console.Write("Your reversed number - {0}", Reverse(fnum));
                    break;

                 
                case 3:
                    string s;
                    Console.Write("Please, enter your line: ");
                    s = Console.ReadLine();
                    Console.Write("Your reversed line - {0}", Reverse(s));

                    break;
                case 4:
                    string ss;
                    char target;
                    bool tcheck = false;
                    Console.Write("Please, enter your line: ");
                    ss = Console.ReadLine();
                    Console.Write("And now enter target character: ");
                    do
                    {
                        check = char.TryParse(Console.ReadLine(), out target);
                        for(int i=0;i< ss.Length; i++)
                        {
                            if (ss[i] == target)
                            {
                                tcheck=true;
                                break;
                            }
                        }
                    } while ((tcheck&check) != true);
                    Console.Write("Your reversed line - {0}", Reverse(ss, target));
                    break;

                case 5:
                    int q;
                    string[] ar;
                    Console.Write("Please, enter the quantity of elements: ");
                    do
                    {
                        check = int.TryParse(Console.ReadLine(), out q);
                    } while (check != true || q<2);
                    ar = new string[q];
                    Console.WriteLine("Now, enter your elements: ");
                    for (int i = 0; i < q; i++)
                    {
                        ar[i] = Console.ReadLine();
                    }
                    Reverse(ref ar);
                    Console.WriteLine("Your reversed array: ");
                    foreach (string el in ar)
                    {
                        Console.WriteLine(el);
                    }
                    break;
            }


            Console.ReadKey();
        }
    }
}
