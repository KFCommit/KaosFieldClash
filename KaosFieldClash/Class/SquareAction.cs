using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaosFieldClash.Class
{
    //La logique qui gère les action des cases
    internal class SquareAction : SquareVisitor
    {
        void SquareVisitor.visit(BaseSquare s)
        {
            throw new NotImplementedException();
        }

        void SquareVisitor.visit(LadderSquare s)
        {
            throw new NotImplementedException();
        }

        void SquareVisitor.visit(QuestionSquare s)
        {
            throw new NotImplementedException();
        }

        void SquareVisitor.visit(SlideSquare s)
        {
            throw new NotImplementedException();
        }

        void SquareVisitor.visit(StartSquare s)
        {
            throw new NotImplementedException();
        }

        void SquareVisitor.visit(SquareEnd s)
        {
            throw new NotImplementedException();
        }
    }
}
