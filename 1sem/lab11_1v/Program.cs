using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab11_1v
{

    class Program
    {
        delegate void ProductOperations(Product a);

        static void Main(string[] args)
        {
            Product item1 = new Product(), item2 = new Product(), item3 = new Product();

            ProductOperations min = Conveyor.Size;
            min += Conveyor.Cut;
            min += Conveyor.Slice;
            min += Conveyor.Drill;
            ProductOperations dye = Conveyor.Size;
            dye += Conveyor.Cut;
            dye += Conveyor.Slice;
            dye += Conveyor.Dye;
            ProductOperations full = Conveyor.Size;
            full += Conveyor.Cut;
            full += Conveyor.Sharpen;
            full += Conveyor.Slice;
            full += Conveyor.Drill;
            full += Conveyor.Dye;
            full += Conveyor.Test;
            full += Conveyor.Pack;

            min(item1);
            dye(item2);
            full(item3);

            Conveyor.Data(item1);
            Conveyor.Data(item2);
            Conveyor.Data(item3);


            Console.Read();
        }
    }
}
