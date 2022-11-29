using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Phone : Machine
    {
        public override string Name { get; }
        public int BatteryPower { get; set; }
        public Phone(string name, int batteryPower)
        {
            Name = name;
            BatteryPower = batteryPower;
        }

        public override string Charge()
        {
            return "Plug";
        }
    }
}
