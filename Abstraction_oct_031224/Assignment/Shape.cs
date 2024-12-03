using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_oct_031224.Assignment
{
  abstract  public class Shape
    {
        public abstract void area();
        abstract public void display();
    }
    public class Circle : Shape
    {
        int r;
        float Result;
        public override void area()
        {
            Console.WriteLine("Enter Radius of Circle");
            r=int.Parse(Console.ReadLine());
            Result = 3.14f * r * r;
        }
        public override void display()
        {
            
            Console.WriteLine("Area of Circle ="+Result);
        }
    }

}
