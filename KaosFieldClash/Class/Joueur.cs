using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaosFieldClash
{
    internal class Joueur
    {
        private string Name;
        private Color Color;

        public Joueur(string name, Color color) {
            Name = name;
            Color = color;
        }

        public string getName()
        {
            return Name;
        }

        public Color getColor()
        {
            return Color;
        }
    }
}
