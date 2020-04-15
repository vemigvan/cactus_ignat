using System;

namespace lab9_1v
{
    class Triangle : Shape, IDraw
    {
        string name;
        public override string Name { get; }
        public override string Color { get; set; }
        public override int Angle { get { return 3; } }
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
        
        public Triangle(string name, double side, string color)
        {
            this.name = name;
            Color = color;
            Side = side;
        }
        public Triangle(string name, double side)
            : this(name, side, "green")
        { }
        public Triangle(string name)
            : this(name, 10)
        { }

        public override double Area() => (side * side * Math.Pow(3, 0.5) / 4);

        public void Draw()
        {
            Console.WriteLine($"Triangle\n\tname - {name}\n\tnumbers of angles - {Angle}\n\tcolor - {Color}");
            Console.WriteLine($"\tside - {Side}\n\tarea - {Area()}");
        }

        }


}
