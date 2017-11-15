using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamProject
{
    class Student
    {
        public string LastName;
        public int Luck;

        public Student(string lastName)
        {
            LastName = lastName;
            Random random = new Random();
            Luck = random.Next(0, 101);
            Thread.Sleep(12);
        }
    }
}
