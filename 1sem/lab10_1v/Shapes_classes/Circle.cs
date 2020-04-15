using System;

namespace lab9_1v
{
    class Circle : Shape, IDraw
    {
        string name;
        public override string Name { get;}
        public override string Color { get; set; }
        public override int Angle { get { return 0; }}
        double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                    radius = value;
            }
        }
        
        public Circle(string name, double radius, string color)
        {
            this.name = name;
            Radius = radius;
            Color = color;
        }

        public Circle(string name, double radius)
            : this(name, radius, "red")
        { }

        public Circle(string name)
            : this(name, 10)
        { }

        public override double Area() => (radius * radius * 3.14);


        public void Draw()
        {
            Console.WriteLine($"Circle\n\tname - {name}\n\tnumbers of angles - {Angle}\n\tcolor - {Color}");
            Console.WriteLine($"\tradius - {Radius}\n\tarea - {Area()}");
        }
    }


}
