namespace lab9_1v
{
    abstract class Shape
    {
        //protected static Random rnd = new Random();

        public abstract string Name {get;}
        public abstract string Color { get; set;}
        public abstract int Angle { get;}
                
        public abstract double Area();
    }


}
