using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerAndPropertyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int x;

            Array1D myArray = new Array1D(n);

            Random rand = new Random();

            Console.WriteLine("ARRAY INITIALIZATION");
            for (int i = 0; i < n * 2; i++)
            {
                myArray[i] = rand.Next(100);

                if (myArray.outOfRange)
                {
                    Console.WriteLine("Index {0}: Value is out of range", i);
                }
            }

            Console.WriteLine("\nPRINTOUT OF ARRAY CONTENT");
            for (int i = 0; i < n * 2; i++)
            {
                x = myArray[i];

                if (!myArray.outOfRange)
                {
                    Console.WriteLine("Index {0}: {1}", i, x);
                }
                else
                {
                    Console.WriteLine("Index {0}: Value is out of range", i);
                }
            }

            myArray.Size = 10;
            Console.WriteLine("\nEXTENDED ARRAY INITIALIZATION");
            for (int i = 0; i < n * 2; i++)
            {
                myArray[i] = rand.Next(100);

                if (myArray.outOfRange)
                {
                    Console.WriteLine("Index {0}: Value is out of range", i);
                }
            }

            Console.WriteLine("\nPRINTOUT OF EXTENDED ARRAY CONTENT");
            for (int i = 0; i < n * 2; i++)
            {
                x = myArray[i];

                if (!myArray.outOfRange)
                {
                    Console.WriteLine("Index {0}: {1}", i, x);
                }
                else
                {
                    Console.WriteLine("Index {0}: Value is out of range", i);
                }
            }

            Console.Read();
        }
    }
}
