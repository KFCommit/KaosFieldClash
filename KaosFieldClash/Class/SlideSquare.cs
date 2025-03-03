using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaosFieldClash
{
    internal class SlideSquare : BaseSquare
    {
        private int IndexOfDestination;

        public SlideSquare(int index, int indexOfDestination) : base(index)
        {
            IndexOfDestination = indexOfDestination;
        }

        public int getDestionationIndex()
        {
            return IndexOfDestination;
        }
    }
}
