// See https://aka.ms/new-console-template for more information
using System;

using Basics_C_.Class;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape a, b;
            Triangle c;
            a = new Square(5);
            b = new Triangle(5, 5, 5);
            c = new Triangle(3, 4, 5);
            Console.WriteLine(a.calculateArea());
            Console.WriteLine(b.calculateArea());
            Console.WriteLine(c.calculateArea(2,6));

            a.printDetails();
            b.printDetails();
            c.printDetails();
        }
    }
}
