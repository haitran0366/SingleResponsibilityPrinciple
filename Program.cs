using System;

namespace SRP_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape shape = new Rectangle(5, 10);
            shape.Area();

            IShape circle = new Circle(10);
            circle.Area();

            IShape triangle = new Triangle(5,10);
            triangle.Area();
        }
    }
}
