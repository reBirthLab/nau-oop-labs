using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerAndPropertyDemo
{
    class Array1D
    {
        int[] array;
        private int size;
        public bool outOfRange;

        // Constructor
        public Array1D(int size)
        {
            array = new int[size];
            this.size = size;
        }

        // Checks if index in range
        private bool inRange(int index)
        {
            if (index >= 0 & index < size)
            {
                return true;
            }

            return false;
        }

        // Indexer
        public int this[int index]
        {
            get
            {
                if (inRange(index))
                {
                    outOfRange = false;
                    return array[index];
                }
                else
                {
                    outOfRange = true;
                    return 0;
                }
            }

            set
            {
                if (inRange(index))
                {
                    array[index] = value;
                    outOfRange = false;
                }
                else
                {
                    outOfRange = true;
                }
            }
        }

        // Property
        public int Size
        {
            get
            {
                return size;
            }

            set
            {
                if (value >= 0)
                {
                    size = value;
                    array = new int[size];
                }
            }
        }
    }
}
