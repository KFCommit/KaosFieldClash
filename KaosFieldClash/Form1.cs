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
		List<FlowLayoutPanel> flowLayoutPanels = new List<FlowLayoutPanel>();

		AffichagePlateau affichagePlateau;

		Joueur[] joueurs = new Joueur[] { new Joueur("Fabio", Color.Red), new Joueur("Kalvin", Color.Blue) };

		Partie partie;

		public Form1()
		{
			affichagePlateau = new AffichagePlateau(this);

			partie = new Partie(joueurs, new Plateau(2, joueurs), new De());

			InitializeComponent();

			addFlowLayoutPanel();

			string path = "Data/questions.json";

			List<Question> question = Json.Load<Question>(path);

			De de = new De();

			de.ViewDice(de.RollDice(), pbDe);

			partie.DeplacerJoueur(0, 2, partie.Joueurs[0]);

			partie.DeplacerJoueur(0, 2, partie.Joueurs[1]);

			partie.newRound();


		}

		public void addFlowLayoutPanel()
		{
			flowLayoutPanels.Add(Square0);
			flowLayoutPanels.Add(Square1);
			flowLayoutPanels.Add(Square2);
			flowLayoutPanels.Add(Square3);
			flowLayoutPanels.Add(Square4);
			flowLayoutPanels.Add(Square5);
			flowLayoutPanels.Add(Square6);
			flowLayoutPanels.Add(Square7);
			flowLayoutPanels.Add(Square8);
			flowLayoutPanels.Add(Square9);
			flowLayoutPanels.Add(Square10);
			flowLayoutPanels.Add(Square11);
			flowLayoutPanels.Add(Square12);
			flowLayoutPanels.Add(Square13);
			flowLayoutPanels.Add(Square14);
			flowLayoutPanels.Add(Square15);
			flowLayoutPanels.Add(Square16);
			flowLayoutPanels.Add(Square17);
			flowLayoutPanels.Add(Square18);
			flowLayoutPanels.Add(Square19);
			flowLayoutPanels.Add(Square20);
			flowLayoutPanels.Add(Square21);
			flowLayoutPanels.Add(Square22);
			flowLayoutPanels.Add(Square23);
			flowLayoutPanels.Add(Square24);
			flowLayoutPanels.Add(Square25);
			flowLayoutPanels.Add(Square26);
			flowLayoutPanels.Add(Square27);
		}

		private void pbDe_Click(object sender, EventArgs e)
		{
			partie.LancerDeeDeLaPartie();
			affichagePlateau.RefreshPlateau(partie.Plateau, flowLayoutPanels);
		}
	}
}
