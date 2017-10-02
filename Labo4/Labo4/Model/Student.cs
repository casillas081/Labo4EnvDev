using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4.Model
{
    public class Student
    {
        private string name;
        private int age;

        public string Name { get=>name; set=>name=value; }
        public int Age { get=>age; set=>age=value; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }
}
