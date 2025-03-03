using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaosFieldClash.Class
{
	internal class AffichagePlateau
	{
		Form1 Form;

		public AffichagePlateau(Form1 form)
		{
			Form = form;
		}

		public void RefreshPlateau(Plateau plateau)
		{
			foreach (Squares square in plateau.PlateauList)
			{

			}
		}

	}
}
