using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaosFieldClash.Class
{
	internal class AffichagePlateau
	{
		Form1 Form;

		public AffichagePlateau(Form1 form)
		{
			Form = form;
		}

		public void RefreshPlateau(Plateau plateau, List<FlowLayoutPanel> flowLayoutPanels)
		{
			foreach (Squares square in plateau.PlateauList)
			{
				int index = square.getIndex();
				flowLayoutPanels[index].Controls.Clear();


				if (square.GetType() == typeof(StartSquare))
				{
					foreach (Joueur joueur in square.Joueur)
					{
						if (joueur != null)
						{
							//MessageBox.Show(square.Joueur[0].getName());
							Label label = new Label();
							label.BackColor = joueur.getColor();
							label.Size = new Size(30, 30);
							flowLayoutPanels[index].Controls.Add(label);
						}
					}
				}
				else if(square.Joueur[0] != null)
				{
					//MessageBox.Show(square.Joueur[0].getName());
					Label label = new Label();
					label.BackColor = square.Joueur[0].getColor();
					label.Size = new Size(30, 30);
					flowLayoutPanels[index].Controls.Add(label);
				}
			}
		}

	}
}
