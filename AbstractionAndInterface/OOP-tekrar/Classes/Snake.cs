using OOP_tekrar.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tekrar.Classes
{
    internal class Snake : Animal,IReptile,ISwim
    {
        public Snake(string name) : base(name)
        {
        }

        public void Reptile()
        {
            Console.WriteLine("Bizler hepimiz surunmeye gelmisiz bu hayata :(");
        }

        public void Swim()
        {
            Console.WriteLine("Snake can swim");
        }
    }
}
