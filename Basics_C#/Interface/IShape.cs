using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_C_.Interface
{
    public interface IShape
    {
        double calculateArea();
        double calculatePerimeter();
        void printDetails();
    }
}
