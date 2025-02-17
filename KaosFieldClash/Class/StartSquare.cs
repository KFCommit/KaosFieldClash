using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaosFieldClash
{
    internal class StartSquare : Square
    {
        Joueur[] joueurs;

        public StartSquare(int numberOfPlayer) : base(0)
        {
            joueurs = new Joueur[numberOfPlayer];
        }


    }
}
