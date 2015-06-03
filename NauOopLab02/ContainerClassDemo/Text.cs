using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauOopLab2
{
    class Text
    {
        private Row[] text;
        private int length = 5;
        private int emptyRow;

        // Constructor
        public Text()
        {
            text = new Row[length];
            emptyRow = 0;
        }

        // Adds new row to text
        public void addRow(string s)
        {
            // Extends text length if the end of text is reached
            if (emptyRow == length)
            {
                Row[] tempText = text;
                length = length + 5;
                text = new Row[length];

                for (int i = 0; i < tempText.Length; i++)
                {
                    text[i] = tempText[i];
                }
            }

            text[emptyRow] = new Row(s);
            emptyRow++;
        }

        // Deletes a row from text
        public void deleteRow(int rowNumber)
        {
            if (rowNumber < 0 || rowNumber >= emptyRow)
            {
                Console.WriteLine("There is no Row {0} in the text.", rowNumber);
            } else
            {
                for (int i = rowNumber; i < emptyRow - 1; i++)
                {
                    text[i] = text[i + 1];
                }

                emptyRow--;

                Console.WriteLine("Row {0} (\"{1}\") was successfully deleted!", rowNumber, text[rowNumber].getContent());
            }
        }

        // Deletes all rows from text
        public void deleteAllRows()
        {
            length = 5;
            text = new Row[length];
            emptyRow = 0;
        }

        // Converts all letters to uppercase
        public void convertAllToUppercase()
        {
            for (int i = 0; i < emptyRow; i++)
            {
                text[i].toUppercase();
            }
        }

        // Finds given row. Returns number of matches
        public int findRowMatches(string s)
        {
            int matchesCounter = 0;

            Console.Write("The string \"{0}\" was found in text ", s);

            for (int i = 0; i < emptyRow; i++)
            {
                if (text[i].getContent() == s)
                {
                    matchesCounter++;
                }
            }

            return matchesCounter;
        }

        // Prints text
        public void printText()
        {
            Console.WriteLine("Current text content:");

            for (int i = 0; i < emptyRow; i++)
            {
                Console.WriteLine("Row {0}: {1}", i, text[i].getContent());
            }
        }

    }
}
