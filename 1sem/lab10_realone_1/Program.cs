using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace lab10_realone_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] kek = new int[5];

            kek[0] = 12;
            kek[1] = 86;
            kek[2] = 34;
            kek[3] = 56;
            kek[4] = 26;

            kek.MySort();
            foreach(int el in kek)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine("-----");

            kek = kek.MyReverse();
            foreach (int el in kek)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine("-----");

            double d = 1234.5678;
            Console.WriteLine(d = d.MyReverse());


            Console.Read();
        }
    }
}
