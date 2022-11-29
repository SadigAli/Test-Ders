using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Classes
{
    internal class Fish : Animal
    {
        public Fish(string name):base(name)
        {
        }

        public string Swim()
        {
            return "I can swim";
        }

    }
}
