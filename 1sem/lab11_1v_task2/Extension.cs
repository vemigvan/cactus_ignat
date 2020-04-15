using System.Collections.Generic;

namespace lab11_1v_task2
{
    static class Extension
    {
        public static List<Student> FindStudent(this List<Student> list, StudentPredicateDelegate requirementlist)
        {
            List<Student> newlist = new List<Student>();
            foreach(Student person in list)
            {
                bool check = true;
                foreach(StudentPredicateDelegate req in requirementlist.GetInvocationList())
                {
                    check = req(person) && check;
                }

                if (check)
                {
                    newlist.Add(person);
                }
            }
            return newlist;
        }
    }
}
