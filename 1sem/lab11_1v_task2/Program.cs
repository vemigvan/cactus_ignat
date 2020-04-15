using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab11_1v_task2
{

    delegate bool StudentPredicateDelegate(Student person);



    class Program
    {
        static void Main(string[] args)
        {
            List<Student> group = new List<Student>();
            group.Add(new Student("Axel", "Troelsen", 16));
            group.Add(new Student("Kira", "Noy", 18));
            group.Add(new Student("Sergey", "Bekov", 21));
            group.Add(new Student("Yana", "Zol", 15));
            group.Add(new Student("Dan", "Kekoranikadze", 14));
            group.Add(new Student("Andrew", "Temin", 13));
            group.Add(new Student("Anton", "Yamen", 20));
            group.Add(new Student("Anya", "Hik", 24));
            group.Add(new Student("ARA", "Kove", 34));
            group.Add(new Student("Sidr", "Love", 17));

            StudentPredicateDelegate Find = Student.IsAdult;
            Find += Student.IsFirstNameA;
            Find += Student.IsLastNamelong;


            foreach(Student el in group.FindStudent(Find))
            {
                Student.Info(el);
            }
            Console.WriteLine("\n");

           StudentPredicateDelegate FindAndrew = (Student person) => (person.FirstName == "Andrew");
            foreach (Student el in group.FindStudent(FindAndrew))
            {
                Student.Info(el);
            }
            Console.WriteLine("\n");


            StudentPredicateDelegate FindTwenty = (Student person) => (person.Age >=20 && person.Age <= 25);
            foreach (Student el in group.FindStudent(FindTwenty))
            {
                Student.Info(el);
            }
            Console.WriteLine("\n");


            StudentPredicateDelegate FindTroelsen = (Student person) => (person.LastName == "Troelsen");
            foreach (Student el in group.FindStudent(FindTroelsen))
            {
                Student.Info(el);
            }
            Console.WriteLine("\n");


            Console.Read();
        }
    }
}
