using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauOopLab2
{
    class Row
    {
        private string content;

        // Constructor
        public Row (string content)
        {
            this.content = content;
        }

        // Prints content of row
        public string getContent()
        {
            return content;
        }

        // Converts all letters to uppercase
        public void toUppercase()
        {
            content = content.ToUpper();
        }

    }
}
