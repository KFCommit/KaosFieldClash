using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaosFieldClash
{
    internal class LadderSquare : Squares
    {
        private int IndexOfDestination;

        public LadderSquare(int index, int indexOfDestination) : base(index)
        {
            IndexOfDestination = indexOfDestination;
        }

        public int getDestionationIndex()
        {
            return IndexOfDestination;
        }

    }
}
