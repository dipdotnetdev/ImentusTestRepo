using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class IndexerClass
    {
        private string[] values = new string[3];
        private string[,] multiDimensionValues = new string[3, 5];

        // Indexer declaration
        public string this[int index]
        {
            get
            {
                return values[index];
            }
            set
            {
                values[index] = value;
            }
        }

        public string this[int index, int newIndex]
        {
            get
            {
                return multiDimensionValues[index, newIndex];
            }
            set
            {
                multiDimensionValues[index, newIndex] = value;
            }
        }
    }
}
