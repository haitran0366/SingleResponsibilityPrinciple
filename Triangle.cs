using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Ex
{
    class Triangle : IShape
    {
        public double _height { get; set; }
        public double _base { get; set; }

        PrintValue printer = new PrintValue();
        public Triangle(double Height, double Base)
        {
            _height = Height;
            _base = Base;
        }

        public void Area()
        {
            printer.printValue((_height * _base) / 2); ;
        }
    }
}
