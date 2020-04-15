using System;

namespace lab11_1v
{
    static class Conveyor
    {
        public static void Size(Product item)
        {
            item.Sized = true;
        }
        public static void Cut(Product item)
        {
            item.Cutoff = true;
        }
        public static void Sharpen(Product item)
        {
            item.Sharpened = true;
        }
        public static void Slice(Product item)
        {
            item.Sliced = true;
        }
        public static void Drill(Product item)
        {
            item.Drilled = true;
        }
        public static void Dye(Product item)
        {
            item.Dyed = true;
        }
        public static void Test(Product item)
        {
            item.Tested = true;
        }
        public static void Pack(Product item)
        {
            item.Packed = true;
        }
        public static void Data(Product item)
        {
            Console.WriteLine($"Item:\n\tSized - {item.Sized}\n\tCutoff - {item.Cutoff}\n\tSharpened - {item.Sharpened}\n\tSliced - {item.Sliced}");
            Console.WriteLine($"\tDrilled - {item.Drilled}\n\tDyed - {item.Dyed}\n\tTested - {item.Tested}\n\tPacked - {item.Packed}");
        }
    }
}
