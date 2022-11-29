using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal abstract class Machine
    {
        public abstract string Name { get; }
        public abstract string Charge();
    }
}
