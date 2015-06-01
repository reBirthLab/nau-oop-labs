using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Segment : Line
    {
        private double length;
        private double deltaX;
        private double deltaY;
        private double sinA;
        private double cosA;

        public Segment(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
        {
            length = this.getLength();

            deltaX = x1 - x2;
            deltaY = y1 - y2;

            sinA = deltaY / length;
            cosA = deltaX / length;

        }

        public void makeFiveUnitsShorter()
        {
            length -= 5;
            deltaX = cosA * length;
            deltaY = sinA * length;

            vertex[1].x = vertex[0].x - (int)Math.Round(deltaX, 0);
            vertex[1].y = vertex[0].y - (int)Math.Round(deltaY, 0);
        }

        public void printData()
        {
            Console.WriteLine("The coordinates of segment vertices:");
            Console.WriteLine("A({0},{1}), B({2}, {3})", 
                vertex[0].x, vertex[0].y, vertex[1].x, vertex[1].y);
            Console.WriteLine("The length of segment is {0} units.\n", Math.Round(length, 2));
        }
    }
}
