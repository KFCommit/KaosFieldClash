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

        public StartSquare(Joueur[] joueurs) : base(0)
        {
            Joueur = joueurs;
        }
        public override void accept(SquareVisitor v)
        {
            v.visit(this);
        }

        public override void removeJoueur(Joueur joueur)
        {
            int IndexOfJoueur = Array.IndexOf(Joueur, joueur);
            this.Joueur[IndexOfJoueur] = null;
        }
    }
}
