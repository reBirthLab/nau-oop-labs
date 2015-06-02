using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class Digits : Strings
    {
        string str;

        public Digits(string str)
        {
            this.str = str;           
        }

        public override void getLength()
        {
            Console.WriteLine("Length of Digits string is {0} symbols.", str.Length);
        }

        public override void moveSymbols()
        {
            Console.WriteLine("Original Digits string: " + str);

            char[] chars = str.ToCharArray();
            char ch = chars[chars.Length - 1];

            for (int i = chars.Length - 1; i > 0; i--)
            {
                chars[i] = chars[i - 1];
            }
            
            chars[0] = ch;

            str = new string (chars);
 
            Console.WriteLine("Modified Digits string: " + str);           
        }
    }
}
