//1.Створити ліст об’єктів, дозволити можливість заповнення з клавіатури і
//вивести кількість об’єктів кожного типу(Char, String, Int, Doble, Bool).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab6_1v
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> olist = new List<object>();
            
            int i;
            double d;
            char c;
            bool b;
            string s;

            string[] type = new string[5] { "Int", "Double", "Char", "Bool", "String" };
            int[] m = new int[5] {0,0,0,0,0};

            

            Console.WriteLine("Welcome! Please, enter your elements. If you finish, enter '_not'");
            for(s = Console.ReadLine(); s!="_not";s= Console.ReadLine())
            {
                if (int.TryParse(s, out i) == false)
                {
                    if (double.TryParse(s, out d) == false)
                    {

                        if (char.TryParse(s, out c) == false)
                        {
                            if (bool.TryParse(s, out b) == false)
                            {
                                olist.Add(s);
                                m[4]++;
                            }
                            else
                            {
                                olist.Add(b);
                                m[3]++;
                            }
                        }
                        else
                        {
                            olist.Add(c);
                            m[2]++;
                        }

                    }
                    else
                    {
                        olist.Add(d);
                        m[1]++;
                    }
                }
                else {
                    olist.Add(i);
                    m[0]++;
                }
            }


            for(int j =0;j<5;j++)
            {
                Console.WriteLine("The quantity of {0} elements - {1}", type[j], m[j]);
            }

            Console.ReadKey();
        }
    }
}
                                                                                         