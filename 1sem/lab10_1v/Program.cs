using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab9_1v
{    
    class Program
    {

        static void Main(string[] args)
        {

            Picture list = new Picture();

            Circle f1 = new Circle("figure1", 5, "orange");
            list.AddShape(f1);
            Square f2 = new Square("figure2", 14);
            list.AddShape(f2);
            Circle f3 = new Circle("figure3");
            list.AddShape(f3);
            Triangle f4 = new Triangle("figure4");
            list.AddShape(f4);
            Painter.DrawShape(list);
            Console.WriteLine("\n-------------------\n");

            list.DeleteShape(200);
            list.DeleteShape(typeof(Triangle));


            Painter.DrawShape(list);
            Console.Read();
        }
    }


}
