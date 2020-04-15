using System;

namespace lab9_1v
{
    class Square : Shape, IDraw
    {
        string name;
        public override string Name { get; }
        public override string Color { get; set; }
        public override int Angle { get { return 4; } }
        double side;
        public double Side
        {
            get { return side; }
            set
            {
                if (value > 0)
                    side = value;
            }
        }
                
        public Square(string name, double side, string color)
        {
            this.name = name;
            Color = color;
            Side = side;}

        public Square(string name, double side)
            :this(name,side, "blue")
        { }

        public Square(string name)
            :this(name, 10)
        { }

        public override double Area() => (side * side); 


        public void Draw()
        {
            Console.WriteLine($"Square\n\tname - {name}\n\tnumbers of angles - {Angle}\n\tcolor - {Color}");
            Console.WriteLine($"\tside - {Side}\n\tarea - {Area()}");
        }
    }


}
