using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tekrar
{
    internal class Programing:IT
    {
        public string Language { get; set; }
        public Programing(string name, string language) : base(name)
        {
            Language = language;
        }

        public override string FullInfo()
        {
            return $"{Name} {Language}";
        }
    }
}
