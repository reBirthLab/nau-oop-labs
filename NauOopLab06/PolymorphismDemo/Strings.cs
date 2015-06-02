using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class Strings
    {
        protected String str;

        public Strings(String str)
        {
            this.str = str;
        }

        public virtual int length()
        {
            return str.Length;
        }
    }
}
