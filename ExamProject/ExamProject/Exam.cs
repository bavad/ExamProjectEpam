using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    class Exam
    {
        public string Name;
        public Teacher Teacher;
        public List<Student> Group;
        public Dictionary<string, double> Results;

        public Exam(string name, Teacher teacher, List<Student> group)
        {
            Name = name;
            Teacher = teacher;
            Group = group;
            Results = new Dictionary<string, double>();
        }

        public void Process()
        {
            double mark;
            Results.Clear();
            foreach (Student student in Group)
            {
                mark = student.Luck * Teacher.Badness;
                Results.Add(student.LastName, mark);
            }
        }

        public void ExamResults()
        {
            Console.WriteLine($"The results of the {Name} exam (Teacher: {Teacher.LastName}) are: ");
            foreach (KeyValuePair<string, double> result in Results)
            {
                Console.WriteLine(result.Key + ": " + result.Value);
            }
        }
    }
}
