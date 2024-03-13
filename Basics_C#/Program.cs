// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;
using Basics_C_.Class;
using Basics_C_.Interface;

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



            //using IEnumeration<IShape>

            /*
              Square square = new Square(8);
              Triangle triangle = new Triangle(5, 5, 7);
              IShape[] shapes = { square, triangle, a, b, c };

              foreach (IShape shape in shapes)
              {
                 shape.printDetails();
              }
            */


            // is and as operators

            Shape[] shapes = { new Square(2), new Triangle(5, 5, 5), new Triangle(3, 4, 4) };

            foreach (var shape in shapes)
            {
                if (shape is Square)
                {
                    Square square = shape as Square;
                    Console.WriteLine($"Square area: {square.calculateArea()}");
                    square.printDetails();
                }
                else if (shape is Triangle)
                {
                    Triangle triangle = shape as Triangle;
                    Console.WriteLine($"Triangle area: {triangle.calculateArea()}");
                    triangle.printDetails();
                }
            }


        }
    }
}
