using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab8_1v
{
    class Car
    {
        private string name, color;
        int year, speed;

        public string Name
        {
            get
            {return name;}
            set
            {name = value;}
        }

        public string Color
        {
            get
            {return color;}
            set
            {color = value;}
        }

        public int Year
        {
            get
            { return year;}
            set
            {
                if (value < 1910 || value > 2019)
                    Console.WriteLine("Incorrect year value");
                else
                    year = value;
            }
        }

        public int Speed
        {
            get
            {return speed;}
            set
            {
                if (value < 1 || value > 450)
                    Console.WriteLine("Incorrect speed value");
                else
                    speed = value;
            }
        }

        public Car(string name, string color, int year, int speed)
        {
            this.name = name;
            this.color = color;
            this.year = year;
            this.speed = speed;
        }
    }


    class Garage
    {
        List<Car> garage = new List<Car>();
        int q = 0;
        public int Quantity
        {
            get
            {
                return q;
            }
        }



        public void AddCar(string name, string color, int year, int speed)
        {
            garage.Add(new Car(name, color, year, speed));
            q++;
        }

        public void ShowCars()
        {
            for (int i = 0; i < q; i++)
            {
                Console.WriteLine("\nCar #{0}: \n\tName: {1}\n\tColor: {2}\n\tYear: {3}\n\tSpeed: {4}",
                    i + 1, garage[i].Name, garage[i].Color, garage[i].Year, garage[i].Speed);
            }
        }

        public void DelCar(int i)
        {
            garage.Remove(garage[i]);
            q--;
        }

        public void FindCar(string name, string color, int year, int speed)
        {
            bool check;
            for (int i = 0; i < q; i++)
            {
                check = true;
                if (name != null)
                {
                    if (garage[i].Name != name)
                        check = check & false;
                }
                if (color != null)
                {
                    if (garage[i].Color != color)
                        check = check & false;
                }
                if (year != 0)
                {
                    if (garage[i].Year != year)
                        check = check & false;
                }
                if (speed != 0)
                {
                    if (garage[i].Speed != speed)
                        check = check & false;
                }

                if (check == true)
                {
                    Console.WriteLine("\nCar #{0}: \n\tName: {1}\n\tColor: {2}\n\tYear: {3}\n\tSpeed: {4}",
                    i + 1, garage[i].Name, garage[i].Color, garage[i].Year, garage[i].Speed);
                }
            }
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            Garage g = new Garage();
            bool check = false;
            int option = 0;
            int num;

            string n, c;
            int y, s;

            do
            {
                Console.Write("Enter car name: ");
                n = Console.ReadLine();

                Console.Write("Enter car color: ");
                c = Console.ReadLine();

                Console.Write("Enter car year: ");
                do
                {
                    check = int.TryParse(Console.ReadLine(), out y);
                } while (check != true);
                Console.Write("Enter car speed: ");

                do
                {
                    check = int.TryParse(Console.ReadLine(), out s);
                } while (check != true);
                Console.Write("\nTo add new car input 'y': ");

                g.AddCar(n, c, y, s);
            } while (Console.ReadLine() == "y");

            do
            {
            Console.WriteLine("\n\n{0} cars in total", g.Quantity);
            Console.WriteLine("Please, select option:");
            Console.WriteLine("\t1 - List of cars");
            Console.WriteLine("\t2 - Add a new car");
            Console.WriteLine("\t3 - Delete a car");
            Console.WriteLine("\t4 - Find a car");
            Console.WriteLine("\t0 - Exit");

                do
                {
                    check = int.TryParse(Console.ReadLine(), out option);
                } while (check != true || (option < 0 || option > 4));

                switch (option)
                {
                    case 1:
                        g.ShowCars();
                        break;

                    case 2:
                        Console.Write("Enter car name: ");
                        n = Console.ReadLine();

                        Console.Write("Enter car color: ");
                        c = Console.ReadLine();

                        Console.Write("Enter car year: ");
                        do
                        {
                            check = int.TryParse(Console.ReadLine(), out y);
                        } while (check != true);
                        Console.Write("Enter car speed: ");

                        do
                        {
                            check = int.TryParse(Console.ReadLine(), out s);
                        } while (check != true);

                        g.AddCar(n, c, y, s);

                break;


                    case 3:
                        Console.Write("Which car must be deleted? Enter it's №: ");
                        do
                        {
                            check = int.TryParse(Console.ReadLine(), out num);
                        } while (check == false || num < 1 || num > g.Quantity + 1);
                        g.DelCar(num-1);
                        break;


                    case 4:
                        Console.WriteLine("Specify required values. If value doesn't role, leave '0'");
                        Console.Write("Enter car name: ");
                        n = Console.ReadLine();
                        if (n == "0")
                            n = null;

                        Console.Write("Enter car color: ");
                        c = Console.ReadLine();
                        if (c == "0")
                            c = null;

                        Console.Write("Enter car year: ");
                        do
                        {
                            
                            check = int.TryParse(Console.ReadLine(), out y);
                        } while (check != true);

                        Console.Write("Enter car speed: ");
                        do
                        {
                            check = int.TryParse(Console.ReadLine(), out s);
                        } while (check != true);


                        g.FindCar(n, c, y, s);

                        break;
                }
            } while (option != 0);
        }
    }
}
