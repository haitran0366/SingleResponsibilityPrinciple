using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Ex
{
    class Circle:IShape
    {
        public double Radius { get; set; }
        private PrintValue printer = new PrintValue();

        public Circle(double radius)
        {
            Radius = radius;
        }
        public void Area()
        {
            printer.printValue(3.14f * Radius * Radius);
        }
    }
}
