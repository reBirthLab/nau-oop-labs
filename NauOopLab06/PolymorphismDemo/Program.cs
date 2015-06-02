using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Strings myString = new Strings();
            Digits digitString = new Digits("8 050 234 54573");
            LowerCase lowerCaseString = new LowerCase("!god save the queen");

            Console.WriteLine("TEST of parent string methods:");
            myString.getLength();
            myString.moveSymbols();
            Console.WriteLine();

            Console.WriteLine("LENGTH OF ORIGINAL OBJECTS:");
            digitString.getLength();
            lowerCaseString.getLength();
            Console.WriteLine();

            Console.WriteLine("POLYMORPHISM DEMO:");
            Strings str;
            str = digitString;
            str.getLength();
            str.moveSymbols();
            Console.WriteLine();

            str = lowerCaseString;
            str.getLength();
            str.moveSymbols();

            Console.Read();
        }
    }
}
