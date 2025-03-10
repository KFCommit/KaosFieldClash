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
				new QuestionSquare(1),
				new QuestionSquare(2),
				new LadderSquare(3, 12),
				new QuestionSquare(4),
				new BaseSquare(5),
				new BaseSquare(6),
				new BaseSquare(7),
				new BaseSquare(8),
				new BaseSquare(9),
				new QuestionSquare(10),
				new BaseSquare(11),
				new QuestionSquare(12),
				new BaseSquare(13),
				new BaseSquare(14),
				new BaseSquare(15),
				new QuestionSquare(16),
				new LadderSquare(17, 24),
				new QuestionSquare(18),
				new BaseSquare(19),
				new SlideSquare(20, 8),
				new BaseSquare(21),
				new QuestionSquare(22),
				new BaseSquare(23),
				new SlideSquare(24, 16),
				new BaseSquare(25),
				new BaseSquare(26),
				new SquareEnd(27),
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
