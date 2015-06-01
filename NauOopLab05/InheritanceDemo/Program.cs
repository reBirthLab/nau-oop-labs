using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        string s = "khjfdhk";
        public int Length
        {
            get
            {
                return s.Length;
            }
        }
        static void Main(string[] args)
        {
            Program sd = new Program();

            Console.WriteLine(sd.Length);

            Console.Read();
        }
    }
}
