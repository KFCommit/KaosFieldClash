using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Threading;

namespace KaosFieldClash.Class
{
	internal class Plateau
	{
		// Variables


		public List<Squares> PlateauList;
		public int nbJoueur;

		// Constructor
		public Plateau(int nbJoueur, Joueur[] joueur)
		{
			this.nbJoueur = nbJoueur;
			PlateauList = new List<Squares>
			{
				new StartSquare(joueur),
				new QuestionSquare(2),
				new QuestionSquare(3),
				new LadderSquare(4, 12),
				new QuestionSquare(5),
				new BaseSquare(6),
				new BaseSquare(7),
				new BaseSquare(8),
				new BaseSquare(9),
				new BaseSquare(10),
				new QuestionSquare(11),
				new BaseSquare(12),
				new QuestionSquare(13),
				new BaseSquare(14),
				new BaseSquare(15),
				new BaseSquare(16),
				new QuestionSquare(17),
				new LadderSquare(18, 24),
				new QuestionSquare(19),
				new BaseSquare(20),
				new SlideSquare(21, 8),
				new BaseSquare(22),
				new QuestionSquare(23),
				new BaseSquare(24),
				new SlideSquare(25, 16),
				new BaseSquare(26),
				new BaseSquare(27),
				new SquareEnd(28),
			};
		}

		// Methods

		public Squares GetSquare(int index) 
		{
			return PlateauList[index];
		}

		public int GetSquareIndex(Squares square)
		{
			return square.getIndex();
        }

		public Squares GetPlayerSquare(Joueur joueur)
		{
            foreach (Squares square in PlateauList)
            {
				//Verifie si le joueur est dans la case (Un seule joueur par case)
				if (joueur == square.Joueur[0])
				{
					return square; //retourne la case
				}
				//Logic pour la case de départ (qui peut posseder plusieur joueur)
				else if(square.GetType() == typeof(StartSquare))
                {
                    //parcours le tableau de joueur
                    foreach (Joueur joueurInStartSquare in square.Joueur) 
                    {
                        //verifie si le joueur corresponds ou pas
                        if (joueur == joueurInStartSquare) 
                        {
                            return square;
                        }
                    }
                }
            }

			//Le joueur n'a pas été trouver
			throw new Exception("Le joueur n'est pas dans le plateau");
        }
	}

}
