using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauOopLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();

            text.addRow("God save our gracious Queen!");
            text.addRow("Long live our noble Queen!");
            text.addRow("God save The Queen!");
            text.addRow("Send her victorious,");
            text.addRow("Happy and glorious,");
            text.addRow("Happy and glorious,");
            text.addRow("Long to reign over us:");
            text.addRow("God save The Queen!");

            Console.WriteLine("\nTEST: Printing text");
            text.printText();

            Console.WriteLine("\nTEST: Delete a row");
            text.deleteRow(10);
            text.deleteRow(4);

            Console.WriteLine();
            text.printText();

            Console.WriteLine("\nTEST: Find row matches");
            Console.WriteLine(text.findRowMatches("God save The Queen!") + " times.");
            Console.WriteLine(text.findRowMatches("God save The King!") + " times.");

            Console.WriteLine("\nTEST: Convert all letters to upper-case");
            text.convertAllToUppercase();
            text.printText();

            Console.ReadLine();
        }
    }
}
