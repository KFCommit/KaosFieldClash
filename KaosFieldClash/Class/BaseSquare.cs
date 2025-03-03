using KaosFieldClash.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaosFieldClash
{
    internal class BaseSquare : Squares
    {
        public BaseSquare(int index) : base(index)
        {
        }

        public override void accept(SquareVisitor v)
        {
            throw new NotImplementedException();
        }
    }
}
