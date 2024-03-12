using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_C_.Class
{
    public  class Triangle: Shape
    {
        public double l1 { get; set; }
        public double l2 { get; set; }
        public double l3 { get; set; }


        public Triangle(double l1, double l2, double l3): base("'Triangle")
        {
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
        }

       

        public override double calculatePerimeter()
        {
            return l1 + l2 + l3;
        }

        public override double calculateArea()
        {
            double s = calculatePerimeter() / 2;
            return Math.Sqrt(s * (s - l1) * (s - l2) * (s - l3));
        }

        public  double calculateArea( double h,double b)//overloading
        {
            return 0.5 * h * b;

        }

        public override void printDetails()
        {
            Console.WriteLine($"This is a triangle with a area: {calculateArea()} and perimeter {calculatePerimeter()}");
        }
    }
}
