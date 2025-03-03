using KaosFieldClash.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaosFieldClash
{
    internal class QuestionSquare : Squares
    {
        public QuestionSquare(int index) : base(index)
        {

        }

        public override void accept(SquareVisitor v)
        {
            v.visit(this);
        }
    }


}
