using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    internal class Rectangle : Shape
    {
        public double Length {  get; set; } 
        public double Breadth { get; set; }   

        public Rectangle(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;  
        }
        public override double GetArea()
        {
            return Length * Breadth;
        }
    }
}
