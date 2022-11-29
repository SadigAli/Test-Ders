using OOP_tekrar.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tekrar.Classes
{
    internal class Duck : Animal,ISwim,IFly
    {
        public Duck(string name) : base(name)
        {
        }

        public void Fly()
        {
            Console.WriteLine("700 bal yigdigimi gordum, konkret ucurduq da bl....");
        }

        public void Swim()
        {
            Console.WriteLine("Ducks can swim");
        }
    }
}
