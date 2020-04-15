using System;

namespace lab11_1v_task2
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int age;
        public int Age
        {
            get { return age; }
            set {
                if (value > 0)
                    age = value;
            }
        }

        public static bool IsAdult(Student person)
        {
            if (person.Age >= 18)
                return true;
            return false;
        }

        public static bool IsFirstNameA(Student person)
        {
            if (person.FirstName[0] == 'A' || person.FirstName[0] == 'a')
                return true;
            return false;
        }

        public static bool IsLastNamelong(Student person)
        {
            if (person.LastName.Length > 3)
                return true;
            return false;
        }

        public static void Info(Student person)
        {
            Console.WriteLine(person.FirstName);
        }

        public Student(string firstname, string lastname, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }

    
    }
}
