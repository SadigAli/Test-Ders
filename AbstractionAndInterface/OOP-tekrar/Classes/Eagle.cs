using OOP_tekrar.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tekrar.Classes
{
    internal class Eagle : Animal,IFly
    {
        public Eagle(string name) : base(name)
        {
        }

        public void Fly()
        {
            Console.WriteLine("I beleive i can fly");
        }
    }
}
