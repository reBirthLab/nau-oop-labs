using System;

namespace ClassDemo
{
    struct Vertex
    {
        public int x, y;
    }

    class Trapezium
    {
        private Vertex[] vertex;
        private int edgeA;
        private int edgeB;
        private double edgeC;
        private double edgeD;
        private int height;


        // Constructor 
        public Trapezium(int x1, int y1, int x2, int x3, int y3, int x4)
        {
            vertex = new Vertex[4];
            vertex[0].x = x1;
            vertex[0].y = y1;
            vertex[1].x = x2;
            vertex[1].y = y1;
            vertex[2].x = x3;
            vertex[2].y = y3;
            vertex[3].x = x4;
            vertex[3].y = y3;

            height = Math.Abs(vertex[0].y - vertex[2].y);
            edgeA = Math.Abs(vertex[0].x - vertex[1].x);
            edgeB = Math.Abs(vertex[2].x - vertex[3].x);
            edgeC = Math.Sqrt(Math.Pow((vertex[0].x - vertex[2].x), 2) + Math.Pow(height, 2));
            edgeD = Math.Sqrt(Math.Pow((vertex[1].x - vertex[3].x), 2) + Math.Pow(height, 2));
        }

        // Destructor
        ~Trapezium()
        {
            Console.WriteLine("The Trapezium object has been destroyed!");
        }

        // Calculates area 
        public double getArea()
        {
            return ((double)(edgeA + edgeB) / 2) * height;
        }

        // Calculates perimeter
        public double getPerimeter()
        {
            return Math.Round((edgeA + edgeB + edgeC + edgeD), 2);
        }

        // Prints coordinates of trapezium vertices
        public void printCoordinates()
        {
            Console.WriteLine("Coordinates of trapezium vertices:");
            Console.WriteLine("A({0},{1}), B({2},{3}), C({4},{5}), D({6},{7})\n", vertex[0].x, vertex[0].y,
                vertex[1].x, vertex[1].y, vertex[2].x, vertex[2].y, vertex[3].x, vertex[3].y);
        }

        // Prints length of trapezium edges
        public void printEdgesLength()
        {
            Console.WriteLine("Length of trapezium edges:");
            Console.WriteLine("AB ({0}), CD({1}), AC({2}), BD({3})\n", edgeA, edgeB,
                Math.Round(edgeC, 2), Math.Round(edgeD, 2));
        }
    }
}
