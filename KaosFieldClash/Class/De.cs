using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace KaosFieldClash.Class
{
	internal class De
	{
		// Variables

		private int nbDe = 1;

		// Constructor
		De()
		{

		}

		// Methods

		public void RollDice()
		{
			Random rnd = new Random();

			nbDe = rnd.Next(rnd.Next(1, 6 + 1));
			
		}

		private void ViewDice(int numDe, PictureBox pbDe)
		{
			pbDe.Image = Image.FromFile("Img/deAnim.gif");
		}
	}

}
