﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaosFieldClash
{
    internal class Square
    {
        private int Index;
        public Joueur[] Joueur { get; private set; }

        public Square(int index)
        {
            Index = index;

            Joueur = new Joueur[1];
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

        public void removeJoueur()
        {
            Joueur[0] = null;
        }
    }
}
