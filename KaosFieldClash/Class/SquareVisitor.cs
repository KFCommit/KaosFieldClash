using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaosFieldClash.Class
{
    internal interface SquareVisitor
    {
        void visit(BaseSquare s);
        void visit(LadderSquare s);
        void visit(QuestionSquare s);
        void visit(SlideSquare s);
        void visit(StartSquare s);
        void visit(SquareEnd s);
    }
}
