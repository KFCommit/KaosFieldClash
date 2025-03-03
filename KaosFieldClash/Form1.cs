using KaosFieldClash.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaosFieldClash
{
    public partial class Form1 : Form
    {
        Partie partie = new Partie(new Joueur[]{new Joueur(), new Joueur()}, new Plateau(2), new De());

        public Form1()
        {
            InitializeComponent();

            string path = "Data/questions.json";

            List<Question> question = Json.Load<Question>(path);

            De de = new De();

            de.ViewDice(de.RollDice(), pbDe);

            partie.DeplacerJoueur(0, 2, partie.Joueurs[0]);

            partie.DeplacerJoueur(0, 2, partie.Joueurs[1]);

            this.Text = partie.Plateau.GetSquare(2).Joueur[0].ToString();
        }
    }
}
