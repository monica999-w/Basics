using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Basics_C_.Interface;


namespace Basics_C_.Class
{
    public abstract class Shape : IShape,IEnumerable<IShape>
    {
        protected List<Shape> shapes= new List<Shape>();
        public string name { get; set; }

        public Shape(string name)
        {
            this.name = name;
        }

        public virtual void printDetails()
        {
            Console.WriteLine("This is a shape");
        }

        public abstract double calculateArea();

        public abstract double calculatePerimeter();

        public IEnumerator<IShape> GetEnumerator()
        {
            return shapes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
