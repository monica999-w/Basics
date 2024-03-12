using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_C_.Class
{
    public class Square : Shape
    {
        public double length { get; set; }

        public Square(double length): base ("Square")
        {
            this.length = length;
        }


        public override double calculateArea()
        {
            return length * length;
        }

        public override double calculatePerimeter()
        {
            return 4 * length;
        }
        public override void printDetails()
        {
            Console.WriteLine($"This is a square with a area: {calculateArea()} and perimeter {calculatePerimeter()}");
        }
    }
}
