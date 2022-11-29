using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tekrar
{
    internal static class StaticClass
    {
        public static int Id { get; set; }

        public static string StaticMethod()
        {
            return "Static Method";
        }

        public static string ExtensionMethod(this string str)
        {
            return $"This is a {str} extension method";
        }
    }
}
