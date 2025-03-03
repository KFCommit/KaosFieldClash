using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaosFieldClash.Class
{
    internal class Partie
    {
        public Joueur[] Joueurs;
        public Plateau Plateau;
        public De De;

        public Partie(Joueur[] joueurs, Plateau plateau, De de)
        {
            Joueurs = joueurs;
            Plateau = plateau;
            De = de;
        }

        public void update()
        {

        }

        public void DeplacerJoueur(int indexCurrentPos, int indexNewPos, Joueur joueur)
        {
            //La case ou se trouve le joueur
            Squares squareCurrent = Plateau.GetSquare(indexCurrentPos);

            //La case ou va se deplacer le joueur
            Squares squareToMove = Plateau.GetSquare(indexNewPos);

            //Verifie si la case est libre
            if (squareToMove.Joueur[0] == null)
            {
                squareToMove.setJoueur(joueur);
                squareCurrent.removeJoueur(joueur);
            }
            else
            {
                indexNewPos++;
                //Parcours les cases jusqu'a que la case soit libre
                while (Plateau.GetSquare(indexNewPos).Joueur[0] != null)
                {
                    Plateau.GetSquare(indexNewPos).setJoueur(joueur);
                    squareCurrent.removeJoueur(joueur);
                }
            }

            //Fait l'evenement spécifique a la case
            SquareAction squareAction = new SquareAction();
            Plateau.GetSquare(indexNewPos).accept(squareAction);

        }
    }
}
