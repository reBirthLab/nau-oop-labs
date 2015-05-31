using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingDemo
{
    struct Vertex
    {
        public int x, y;
    }

    class Rhombus
    {
        private Vertex[] vertex;
        private double edgeA;
        private int diagonalAC;
        private int diagonalBD;

        // Default constructor
        public Rhombus():this(0,0,12,25)
        {
        }

        // Constructor with parameters
        public Rhombus(int x1, int y1, int x2, int y2)
        {
            vertex = new Vertex[4];
            vertex[0].x = x1;
            vertex[0].y = y1;
            vertex[1].x = x2;
            vertex[1].y = y2;
            vertex[2].x = x1 + Math.Abs((x1 - x2) * 2);
            vertex[2].y = y1;
            vertex[3].x = x2;
            vertex[3].y = y2 - Math.Abs((y1 - y2) * 2);

            edgeA = Math.Sqrt(Math.Pow((vertex[0].x - vertex[2].x), 2) + Math.Pow((vertex[0].y - vertex[1].y), 2)); ;
            diagonalAC = Math.Abs(vertex[0].x - vertex[2].x);
            diagonalBD = Math.Abs(vertex[1].y - vertex[3].y);
        }

        // Constructor for copying
        public Rhombus(Rhombus rhombus)
        {
            vertex = new Vertex[4];
            vertex[0] = rhombus.vertex[0];
            vertex[1] = rhombus.vertex[1];
            vertex[2] = rhombus.vertex[2];
            vertex[3] = rhombus.vertex[3];

            edgeA = rhombus.edgeA;
            diagonalAC = rhombus.diagonalAC;
            diagonalBD = rhombus.diagonalBD;
        }

        // Calculates area 
        public double getArea()
        {
            return (double)(diagonalAC * diagonalBD) / 2;
        }

        // Calculates perimeter
        public double getPerimeter()
        {
            return Math.Round((edgeA * 4), 2);
        }

        // Prints coordinates of rhombus vertices
        public void printCoordinates()
        {
            Console.WriteLine("Coordinates of rhombus vertices:");
            Console.WriteLine("A({0},{1}), B({2},{3}), C({4},{5}), D({6},{7})\n", vertex[0].x, vertex[0].y,
                vertex[1].x, vertex[1].y, vertex[2].x, vertex[2].y, vertex[3].x, vertex[3].y);
        }

        // Prints length of rhombus edge
        public void printEdgeLength()
        {
            Console.WriteLine("Length of rhombus edge AB is {0} units.\n", Math.Round(edgeA, 2)); 
        }

        // Prints length of rhombus diagonals
        public void printDiagonalsLength()
        {
            Console.WriteLine("Length of rhombus diagonals: AC ({0}), BD ({1}) units.\n", diagonalAC, diagonalBD);
        }
    }
}
