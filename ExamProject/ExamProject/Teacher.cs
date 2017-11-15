using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamProject
{
    class Teacher
    {
        public string LastName;
        public double Badness;

        public Teacher(string lastName)
        {
            LastName = lastName;
            Random random = new Random();
            Badness = (double)random.Next(5, 11) / 10;
            Thread.Sleep(12);
        }
    }
}
