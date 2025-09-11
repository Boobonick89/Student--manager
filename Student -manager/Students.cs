using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student__manager
{
    public class Student
    {
        public int Id { get; }
        public string Name { get; }
        public int Age { get; }

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString()=>$"{Id} {Name} {Age}";
    }
}
