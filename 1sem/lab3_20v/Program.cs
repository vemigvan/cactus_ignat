//20.	Дані координати (як цілі від 1 до 8) двох різних полів шахівниці. 
//Якщо ферзь за один хід може перейти з одного поля на інше, 
//вивести логічне значення True, інакше вивести значення False. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3_20v_add
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2;
            bool check = false;

            Console.WriteLine("Welcome!");
            do
            {
                Console.WriteLine("Please, enter coordinats of first position:");
                int.TryParse(Console.ReadLine(), out x1);
                int.TryParse(Console.ReadLine(), out y1);
            } while (x1 > 8 || x1 < 1 || y1 > 8 || y1 < 1);

            do
            {
                Console.WriteLine("And now, enter coordinats of second position:");
                int.TryParse(Console.ReadLine(), out x2);
                int.TryParse(Console.ReadLine(), out y2);
            } while (x2 > 8 || x2 < 1 || y2 > 8 || y2 < 1);

            if (((x1 == x2 || y1 == y2)
                || (Math.Abs(x1 - x2) == Math.Abs(y1 - y2)))
                && !(x1 == x2 && y1 == y2))
            {
                check = true;
            }

            Console.WriteLine("The queen can move from 1st position to 2nd position: {0}", check);

            Console.ReadKey();
        }
    }
}
