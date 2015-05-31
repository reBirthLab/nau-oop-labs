using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Trapezium trapezium1 = new Trapezium(0, 0, 25, 5, 12, 22);
            Trapezium trapezium2 = new Trapezium(-10, -10, 30, 0, 10, 25);

            trapezium1.printCoordinates();
            trapezium1.printEdgesLength();
            Console.WriteLine("Trapezium 1 area is {0} units.\n", trapezium1.getArea());
            Console.WriteLine("Trapezium 1 perimeter is {0} units.\n", trapezium1.getPerimeter());
            Console.WriteLine("\n");

            trapezium2.printCoordinates();
            trapezium2.printEdgesLength();
            Console.WriteLine("Trapezium 2 area is {0} units.\n", trapezium2.getArea());
            Console.WriteLine("Trapezium 2 perimeter is {0} units.\n", trapezium2.getPerimeter());

            Console.ReadLine();

            trapezium1 = null;
            trapezium2 = null;
            GC.Collect();

            Console.Read();
        }
    }
}
