using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Ex
{
    class Rectangle : IShape
    {
        public double Lenght { get; set; }
        public double Width { get; set; }
        PrintValue printValue = new PrintValue();
        public Rectangle(double lenght, double width)
        {
            Lenght = lenght;
            Width = width;
        }
        public void Area()
        {
            printValue.printValue(Lenght * Width);
        }
    }
}
