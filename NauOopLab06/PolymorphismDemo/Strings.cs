using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class Strings
    {
        public virtual void getLength()
        {
            Console.WriteLine("getLength method of parent class.");
        }

        public virtual void moveSymbols()
        {
            Console.WriteLine("moveSymbols method of parent class.");
        }
    }
}
