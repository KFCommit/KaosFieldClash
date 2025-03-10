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

        private int idJoueurJouant = -1;

        public Partie(Joueur[] joueurs, Plateau plateau, De de)
        {
            Joueurs = joueurs;
            Plateau = plateau;
            De = de;
        }

        public void newRound()
        {
            idJoueurJouant++;
            if (idJoueurJouant >= Joueurs.Count())
            {
                idJoueurJouant = 0;
            }
        }

        public void LancerDeeDeLaPartie()
        {
            int result = De.RollDice();

            Joueur joueurPlaying = Joueurs[idJoueurJouant];

            Squares playerSquare = Plateau.GetPlayerSquare(joueurPlaying);

            int playerSquareIndex = Plateau.GetSquareIndex(playerSquare);

            DeplacerJoueur(playerSquareIndex, playerSquareIndex + result, joueurPlaying);

            newRound();
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
