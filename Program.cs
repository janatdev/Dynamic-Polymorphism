using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    //Dynamic Polymorphism

    internal abstract class Shape
    {
        public abstract int CalcArea();
    }

    internal class Rectangle : Shape
    {
        private int len;
        private int wid;

        public Rectangle(int a = 0, int b = 0)
        {
            len = a;
            wid = b;
        }

        public override int CalcArea()
        {
            Console.WriteLine("Rectangle Area");
            return len*wid;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var rect = new Rectangle(5, 10);

            double area = rect.CalcArea();

            Console.WriteLine("Area : {0}", area);

            Console.ReadLine();
        }
    }
}