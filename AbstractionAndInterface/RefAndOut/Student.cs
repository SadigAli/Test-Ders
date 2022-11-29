using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public Student(int id, string name, string lastname)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
        }

        public string GetFullName()
        {
            return $"{Name} {Lastname}";
        }
    }
}
