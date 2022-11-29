using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Car : Machine
    {
        public readonly int Id;
        public override string Name { get; }
        public int Speed { get; set; }

        public Car(int id,string name, int speed)
        {
            Id = id;
            Name = name;
            Speed = speed;
        }

        public override string Charge()
        {
            return "Accumulator";
        }
    }
}
