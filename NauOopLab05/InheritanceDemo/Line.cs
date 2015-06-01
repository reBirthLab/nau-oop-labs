using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    struct Vertex
    {
        public int x, y;
    }

    class Line
    {
        private Vertex[] vertex;

        public Line(int x1, int y1, int x2, int y2)
        {
            vertex = new Vertex[2];
            vertex[0].x = x1;
            vertex[0].y = y1;
            vertex[1].x = x2;
            vertex[1].y = y2;
        }

        public double getLength()
        {
            return Math.Sqrt(Math.Pow((vertex[0].x - vertex[1].x), 2) + Math.Pow((vertex[0].y - vertex[1].y), 2));
        }
    }
}
