using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tekrar.Classes
{
    internal class Rectangle : Figure
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override int Area()
        {
            return Width * Height;
        }

        public override int Perimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
