using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rhombus R1 = new Rhombus();
            Rhombus R2 = new Rhombus(-10, -5, 5, 22);
            Rhombus R3 = new Rhombus(R1);

            Console.WriteLine("RHOMBUS R1 DATA:\n");
            R1.printCoordinates();
            R1.printEdgeLength();
            R1.printDiagonalsLength();
            Console.WriteLine("The area of rhombus R1 is {0} units.\n", R1.getArea());
            Console.WriteLine("The perimetr of rhombus R1 is {0} units.\n\n", R1.getPerimeter());

            Console.WriteLine("RHOMBUS R2 DATA:\n");
            R2.printCoordinates();
            R2.printEdgeLength();
            R2.printDiagonalsLength();
            Console.WriteLine("The area of rhombus R2 is {0} units.\n", R2.getArea());
            Console.WriteLine("The perimetr of rhombus R2 is {0} units.\n\n", R2.getPerimeter());

            Console.WriteLine("RHOMBUS R3 DATA:\n");
            R3.printCoordinates();
            R3.printEdgeLength();
            R3.printDiagonalsLength();
            Console.WriteLine("The area of rhombus R3 is {0} units.\n", R3.getArea());
            Console.WriteLine("The perimetr of rhombus R3 is {0} units.\n\n", R3.getPerimeter());

            Console.Read();
        }
    }
}
