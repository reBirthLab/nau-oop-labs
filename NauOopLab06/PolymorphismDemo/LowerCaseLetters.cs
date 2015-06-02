using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class LowerCase : Strings
    {
        String str;

        public LowerCase(string str)
        {
            this.str = str;
        }

        public override void getLength()
        {
            Console.WriteLine("Length of Lower-case string is {0} symbols.", str.Length);
        }

        public override void moveSymbols()
        {
            Console.WriteLine("Original Lower-case string: " + str);

            char[] chars = str.ToCharArray();
            char ch = chars[0];

            for (int i = 0; i < chars.Length - 1; i++)
            {
                chars[i] = chars[i + 1];
            }

            chars[chars.Length - 1] = ch;

            str = new string(chars);

            Console.WriteLine("Modified Lower-case string: " + str);
        }
    }
}
