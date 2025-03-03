using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaosFieldClash.Class
{
    internal class SquareEnd : Squares
    {
        public SquareEnd(int index) : base(index)
        {
        }

        public override void accept(SquareVisitor v)
        {
            v.visit(this);
        }
    }
}
