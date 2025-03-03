using KaosFieldClash.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaosFieldClash
{
    internal class StartSquare : Squares
    {
        Joueur[] joueurs;

        public StartSquare(int numberOfPlayer) : base(0)
        {
            joueurs = new Joueur[numberOfPlayer];
        }
        public override void accept(SquareVisitor v)
        {
            v.visit(this);
        }


    }
}
