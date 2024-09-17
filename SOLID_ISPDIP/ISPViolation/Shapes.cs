using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ISPDIP.ISPViolation
{
    internal interface IShape
    {
        double GetArea();

        void Draw();
    }

    internal class Circle : IShape 
    {
        public void Draw()
        {
            Console.WriteLine("Area here");
        }
        public double GetArea() {
            Console.WriteLine("Getting the Circle's area");
            return 0;
        }
    }

    internal class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing the Rectangle");
        }
        public double GetArea() {
            Console.WriteLine("Getting the Rectangle's Area");
            return 0;
        }
    }
}
