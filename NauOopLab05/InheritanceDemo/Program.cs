using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Segment seg1 = new Segment(0, 0, 23, -5);
            Segment seg2 = new Segment(-5, -5, 20, 10);

            Console.WriteLine("SEGMENT 1");
            seg1.printData();

            Console.WriteLine("SEGMENT 1 (5 units shorter)");
            seg1.makeFiveUnitsShorter();
            seg1.printData();

            Console.WriteLine("SEGMENT 2");
            seg2.printData();

            Console.WriteLine("SEGMENT 2 (5 units shorter)");
            seg2.makeFiveUnitsShorter();
            seg2.printData();

            Console.Read();
        }
    }
}
