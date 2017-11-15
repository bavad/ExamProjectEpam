using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Ivanov");
            List<Student> group = new List<Student>();
            group.Add(new Student("Petrov"));
            group.Add(new Student("Sidorov"));
            group.Add(new Student("Vasilyev"));
            Exam exam = new Exam("Math", teacher, group);

            exam.Process();
            exam.ExamResults();
        }
    }
}
