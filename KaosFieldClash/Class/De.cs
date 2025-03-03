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
	internal class De
	{
		// Variables

		private int nbDe = 1;

		// Constructor
		public De()
		{

		}

		// Methods

		public int RollDice()
		{
			Random rnd = new Random();

			nbDe = rnd.Next(rnd.Next(1, 6 + 1));
			
			return nbDe;
		}

		public async void ViewDice(int numDe, PictureBox pbDe)
		{
			pbDe.Image = Image.FromFile("Img/deAnim.gif");
			await Task.Delay(2000);

			pbDe.Image = Image.FromFile($"Img/de{numDe}.png");
		}
	}

}
