using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaosFieldClash.Class
{
    internal abstract class Squares
    {
        public abstract void accept(SquareVisitor v);
        private int Index;
        public Joueur[] Joueur { get; protected set; }

        public Squares(int index)
        {
            Index = index;

            Joueur = new Joueur[1];
        }

        public int getIndex()
        {
            return Index;
        }

        public virtual void setJoueur(Joueur joueur)
        {
            if (Joueur[0] == null)
            {
                Joueur[0] = joueur;
            }
            else
            {
                throw new ArgumentException($"Le joueur {joueur} ne peut pas ce deplacer sur la case {this}, car il y a déjà un joueur {Joueur}");
            }
        }

        public virtual void removeJoueur(Joueur joueur)
        {
            Joueur[0] = null;
        }
    }
}
